#region Usings
using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using DirectShowLib;
using MediaPoint.Common.DirectShow.MediaPlayers;
using MediaPoint.Common.MediaFoundation.Interop;
using System.IO;
using System.Reflection;

#endregion

namespace MediaPoint.Common.MediaFoundation
{
    #region Custom COM Types

    [ComVisible(true), ComImport, SuppressUnmanagedCodeSecurity,
     Guid("00000001-0000-0000-C000-000000000046"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IClassFactory
    {
        [PreserveSig]
        int CreateInstance([In, MarshalAs(UnmanagedType.Interface)] object pUnkOuter,
                           ref Guid riid,
                           [Out, MarshalAs(UnmanagedType.Interface)] out object obj);

        [PreserveSig]
        int LockServer([In] bool fLock);
    }

    [ComVisible(true), ComImport, SuppressUnmanagedCodeSecurity,
     Guid("B92D8991-6C42-4e51-B942-E61CB8696FCB"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IEVRPresenterCallback
    {
        [PreserveSig]
        int PresentSurfaceCB(IntPtr pSurface);
        [PreserveSig]
        int FoundPlate([MarshalAs(UnmanagedType.LPWStr)] string text, int left, int top, int right, int bottom, float angle, int confidence, [MarshalAs(UnmanagedType.LPWStr)] string nattext, int natconf, [MarshalAs(UnmanagedType.LPWStr)] string natplate);
    }

    [ComVisible(true), ComImport, SuppressUnmanagedCodeSecurity,
     Guid("9019EA9C-F1B4-44b5-ADD5-D25704313E48"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IEVRPresenterRegisterCallback
    {
        [PreserveSig]
        int RegisterCallback(IEVRPresenterCallback pCallback);
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct POINT
    {
        public Int32 m_x;
        public Int32 m_y;

        public POINT(Int32 x, Int32 y)
        {
            m_x = x;
            m_y = y;
        }
    }

    [ComVisible(true), ComImport, SuppressUnmanagedCodeSecurity,
     Guid("4527B2E7-49BE-4b61-A19D-429066D93A99"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IEVRPresenterSettings
    {
        [PreserveSig]
        int SetBufferCount(int bufferCount);
		[PreserveSig]
		int GetDirect3DDevice(out IntPtr device);
		[PreserveSig]
		int SetPixelShader([MarshalAs(UnmanagedType.BStr)] string code, [MarshalAs(UnmanagedType.BStr)] ref string errors);
        [PreserveSig]
        int HookEVR(IBaseFilter evr);
        [PreserveSig]
        int SetAdapter(POINT p);
    }
    #endregion

    [ComVisible(true)]
    public class EvrPresenter : ICustomAllocator, IEVRPresenterCallback
    {
        private IntPtr m_lastSurface;

        private EvrPresenter()
        {
        }

        #region Interop

        /// <summary>
        /// The GUID of our EVR custom presenter COM object
        /// </summary>
        public static readonly Guid EVR_PRESENTER_CLSID = new Guid(0x9807fc9c, 0x807b, 0x41e3, 0x98, 0xa8, 0x75, 0x17, 0x6f, 0x95, 0xa0, 0x63);

        /// <summary>
        /// The GUID of IUnknown
        /// </summary>
		public static readonly Guid IUNKNOWN_GUID = new Guid("{00000000-0000-0000-C000-000000000046}");

        /// <summary>
        /// Static method in the 32 bit dll to create our IClassFactory
        /// </summary>
        [PreserveSig]
        [DllImport("EvrPresenter32.dll", EntryPoint = "DllGetClassObject")]
        public static extern int DllGetClassObject32([MarshalAs(UnmanagedType.LPStruct)] Guid clsid,
                                                      [MarshalAs(UnmanagedType.LPStruct)] Guid riid,
                                                      [MarshalAs(UnmanagedType.IUnknown)] out object ppv);

        /// <summary>
        /// Static method in the 62 bit dll to create our IClassFactory
        /// </summary>
        [PreserveSig]
        [DllImport("EvrPresenter64.dll", EntryPoint = "DllGetClassObject")]
		public static extern int DllGetClassObject64([MarshalAs(UnmanagedType.LPStruct)] Guid clsid,
                                                      [MarshalAs(UnmanagedType.LPStruct)] Guid riid,
                                                      [MarshalAs(UnmanagedType.IUnknown)] out object ppv);

        #endregion

        /// <summary>
        /// Returns the bittage of this process, ie 32 or 64 bit
        /// </summary>
        private static int ProcessBits
        {
            get { return IntPtr.Size*8; }
        }

        /// <summary>
        /// The custom EVR video presenter COM object
        /// </summary>
        public IMFVideoPresenter VideoPresenter { get; private set; }

        #region ICustomAllocator Members
        /// <summary>
        /// Invokes when a new frame has been allocated
        /// to a surface
        /// </summary>
        public event Action NewAllocatorFrame;

        /// <summary>
        /// Invokes when a new surface has been allocated
        /// </summary>
        public event NewAllocatorSurfaceDelegate NewAllocatorSurface;
        public event PlateFoundDelegate PlateFound;

        public void Dispose()
        {
            Marshal.ReleaseComObject(VideoPresenter);
        }

        #endregion

        #region IEVRPresenterCallback Members

        /// <summary>
        /// Called by the custom EVR Presenter, notifying that
        /// there is a new D3D surface and/or there needs to be
        /// a frame rendered
        /// </summary>
        /// <param name="pSurface">The Direct3D surface</param>
        /// <returns>A HRESULT</returns>
        public int PresentSurfaceCB(IntPtr pSurface)
        {
            /* Check if the surface is the same as the last*/
            if(m_lastSurface != pSurface)
                InvokeNewAllocatorSurface(pSurface);

            /* Store ref to the pointer so we can compare
             * it next time this method is called */
            m_lastSurface = pSurface;

            InvokeNewAllocatorFrame();
            return 0;
        }

        public int FoundPlate(string text, int left, int top, int right, int bottom, float angle, int confidence, string nattext, int natconf, string natplate)
        {
            var del = PlateFound;
            if (del != null) del(this, text, left, top, right, bottom, angle, confidence, nattext, natconf, natplate);
            return 0;
        }

        #endregion

        /// <summary>
        /// Create a new EVR video presenter
        /// </summary>
        /// <returns></returns>
        public static EvrPresenter CreateNew()
        {
            object comObject;

            int hr;

            /* Our exception var we use to hold the exception
             * until we need to throw it (after clean up) */
            Exception exception = null;

            /* A COM object we query form our native library */
            IClassFactory factory = null;

            /* Create our 'helper' class */
            var evrPresenter = new EvrPresenter();

            /* Call the DLL export to create the class factory */
			if (ProcessBits == 32)
			{
				hr = DllGetClassObject32(EVR_PRESENTER_CLSID, IUNKNOWN_GUID, out comObject);
			}
			else if (ProcessBits == 64)
			{
				hr = DllGetClassObject64(EVR_PRESENTER_CLSID, IUNKNOWN_GUID, out comObject);
			}
			else
			{
				exception = new Exception(string.Format("{0} bit processes are unsupported", ProcessBits));
				goto bottom;
			}

            /* Check if our call to our DLL failed */
            if(hr != 0 || comObject == null)
            {
                exception = new COMException("Could not create a new class factory.", hr);
                goto bottom;
            }

            /* Cast the COM object that was returned to a COM interface type */
            factory = comObject as IClassFactory;

            if(factory == null)
            {
                exception = new Exception("Could not QueryInterface for the IClassFactory interface");
                goto bottom;
            }

            /* Get the GUID of the IMFVideoPresenter */
            Guid guidVideoPresenter = typeof(IMFVideoPresenter).GUID;

            /* Creates a new instance of the IMFVideoPresenter */
            factory.CreateInstance(null, ref guidVideoPresenter, out comObject);

            /* QueryInterface for the IMFVideoPresenter */
            var presenter = comObject as IMFVideoPresenter;

            /* QueryInterface for our callback registration interface */
            var registerCb = comObject as IEVRPresenterRegisterCallback;

            if(registerCb == null)
            {
                exception = new Exception("Could not QueryInterface for IEVRPresenterRegisterCallback");
                goto bottom;
            }

            /* Register the callback to the 'helper' class we created */
            registerCb.RegisterCallback(evrPresenter);

            /* Populate the IMFVideoPresenter */
            evrPresenter.VideoPresenter = presenter;
             
            bottom:

            if(factory != null)
                Marshal.FinalReleaseComObject(factory);

            if(exception != null)
                throw exception;

            return evrPresenter;
        }

        #region Event Invokers
        /// <summary>
        /// Fires the NewAllocatorFrame event
        /// </summary>
        private void InvokeNewAllocatorFrame()
        {
            var newAllocatorFrameAction = NewAllocatorFrame;
            if(newAllocatorFrameAction != null) newAllocatorFrameAction();
        }

        /// <summary>
        /// Fires the NewAlloctorSurface event
        /// </summary>
        /// <param name="pSurface">D3D surface pointer</param>
        private void InvokeNewAllocatorSurface(IntPtr pSurface)
        {
            var del = NewAllocatorSurface;
            if(del != null) del(this, pSurface);
        }
        #endregion
    }
}