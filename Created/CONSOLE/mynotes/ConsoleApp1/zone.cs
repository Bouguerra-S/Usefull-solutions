using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scanmynotes
{
    public class zone
    {
        private int x;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        private int y;

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        private int w;

        public int W
        {
            get { return w; }
            set { w = value; }
        }

        private int h;

        public int H
        {
            get { return h; }
            set { h = value; }
        }
        public zone(int a, int b, int c, int d)
        {
            X = a;
            Y = b;
            W = c;
            H = d;
        }


    }
}
