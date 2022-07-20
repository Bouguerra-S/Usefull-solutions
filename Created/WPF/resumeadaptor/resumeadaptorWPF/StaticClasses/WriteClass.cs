using Microsoft.Win32;
using System.IO;
using System.Threading.Tasks;

namespace resumeadaptorWPF.StaticClasses
{
    public class WriteClass
    {
        public async Task WriteString(string myString)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == true)
                await File.WriteAllTextAsync(saveFileDialog1.FileName, myString);
        }

    }
}
