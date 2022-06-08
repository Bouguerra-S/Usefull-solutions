using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace findMyInputs
{
    public class finderbytext
    {
        public string tofindinput;
        public finderbytext(string tofind)
        {
            tofindinput = tofind;
        }

        public void find()
        {
            ManagementObjectSearcher objSearcher = new ManagementObjectSearcher(
           "SELECT * FROM "+ tofindinput);

            ManagementObjectCollection objCollection = objSearcher.Get();

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
        }
    }
}
