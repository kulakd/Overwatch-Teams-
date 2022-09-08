using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OWL_Standings
{
    class TC3 : IComparer
    {
        public int Compare(object x, object y)
        {
            return (new CaseInsensitiveComparer()).Compare(((Team)x).F3, ((Team)y).F3);
        }
    }
}

