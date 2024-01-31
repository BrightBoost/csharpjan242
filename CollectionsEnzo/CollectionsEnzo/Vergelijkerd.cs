using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsEnzo
{
    internal class Vergelijkerd : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            if(x.Length - y.Length == 0) {
                return -x.CompareTo(y);
            }
            return x.Length - y.Length;
        }
    }
}
