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
        private string Text;
        private Font Fnt;
        public Brush Brsh;
        public float X;
        public float Y;

        public string text
        {
            get { return Text; }
            set { Text = value; }
        }

        public Font fnt
        {
            get { return Fnt; }
            set { Fnt = value; }
        }


        public float x
        {
            get { return X; }
            set { X = value; }
        }


        public Brush brsh
        {
            get { return Brsh; }
            set { Brsh = value; }
        }


        public float y
        {
            get { return Y; }
            set { Y = value; }
        }

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
