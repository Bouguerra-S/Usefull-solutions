using System;
using System.Management;

namespace findMyInputs
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagementObjectSearcher objSearcher = new ManagementObjectSearcher(
           "SELECT * FROM Win32_Keyboard");

            ManagementObjectCollection objCollection = objSearcher.Get();

            foreach (ManagementObject obj in objCollection)
            {
                foreach (PropertyData property in obj.Properties)
                {
                    if (property.Name=="Description" || property.Name=="Status")
                    {
                        Console.Out.WriteLine(String.Format("{0}:{1}", property.Name, property.Value));

                    }
                }
            }

            objSearcher = new ManagementObjectSearcher(
           "SELECT * FROM Win32_PointingDevice");

            objCollection = objSearcher.Get();

            foreach (ManagementObject obj in objCollection)
            {
                foreach (PropertyData property in obj.Properties)
                {
                    if (property.Name == "Description" || property.Name == "Status")
                    {
                        Console.Out.WriteLine(String.Format("{0}:{1}", property.Name, property.Value));

                    }
                }
            }
            //todo: cameras microphones scanners
        }
    }
}
