using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resumeadaptorWPF.StaticClasses
{
    public class WriteClass
    {
        public  async Task WriteString(string mystring)
        {
            await File.WriteAllTextAsync("myCV.txt", mystring);
        }

    }
}
