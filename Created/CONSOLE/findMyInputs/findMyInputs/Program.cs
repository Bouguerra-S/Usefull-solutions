using System;
using System.Management;

namespace findMyInputs
{
    class Program
    {
        static void Main(string[] args)
        {
            finderbytext myFinder = new finderbytext("Win32_Keyboard");
            myFinder.find();
            myFinder = new finderbytext("Win32_PointingDevice");
            myFinder.find();
            myFinder = new finderbytext("Win32_PointingDevice");
            myFinder.find();

            //todo: cameras microphones scanners
        }
    }
}
