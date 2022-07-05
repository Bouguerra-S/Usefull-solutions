using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace resumeadaptorWPF.StaticClasses
{
    public class WriteClass
    {
        public  async Task WriteString(string mystring)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == true)
            {
                await File.WriteAllTextAsync(saveFileDialog1.FileName , mystring);
            }
        }

    }
}
