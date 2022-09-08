using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OWL_Standings
{
    class TeamCompare : IComparer
    {
        public int Compare(object x, object y)
        {
            return (new CaseInsensitiveComparer()).Compare(((Team)x).FINAL, ((Team)y).FINAL);
        }
    }
}
