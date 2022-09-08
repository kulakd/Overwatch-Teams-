using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OWL_Standings
{
    class TC5 : IComparer
    {
        public int Compare(object x, object y)
        {
            return (new CaseInsensitiveComparer()).Compare(((Team)x).F5, ((Team)y).F5);
        }
    }
}

