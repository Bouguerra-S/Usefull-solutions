using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scanmynotes
{
    public class note
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string text;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        private List<tag> tags;

        public List<tag> Tags
        {
            get { return tags; }
            set { tags = value; }
        }



    }
}
