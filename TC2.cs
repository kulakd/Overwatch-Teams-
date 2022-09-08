using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OWL_Standings
{
    class TC2 : IComparer
    {
        public int Compare(object x, object y)
        {
            return (new CaseInsensitiveComparer()).Compare(((Team)x).F2, ((Team)y).F2);
        }
    }
}
