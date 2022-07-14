using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resumeadaptorWPF.Structs
{
    public struct reportItem
    {
        public string word;
        public int offerCount;
        public int CVcount;
        public reportItem(string pword, int pOfferCount, int pCVcount)
        {
            word = pword;
            offerCount = pOfferCount;
            CVcount = pCVcount;
        }
        
    }
}
