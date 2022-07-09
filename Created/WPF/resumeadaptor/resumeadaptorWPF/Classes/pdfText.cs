using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resumeadaptorWPF.Classes
{
    public class pdfText
    {
        public string text;
        public Font fnt;
        public Brush brsh;
        public float x;
        public float y;
        public pdfText()
        {

        }
        public pdfText(string ptxt,Font pfnt,Brush pbrsh,float px,float py)
        {
            text = ptxt;
            fnt = pfnt;
            brsh = pbrsh;
            x = px; y = py;

            text.Replace("-", "");
        }
    }
}
