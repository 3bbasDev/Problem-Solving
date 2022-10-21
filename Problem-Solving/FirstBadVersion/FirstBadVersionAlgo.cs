using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstBadVersion
{
    public class FirstBadVersionAlgo
    {
        public int FirstBadVersion(int n)
        {
            //if (n == 1) return 1;
            //int begin = 1, end = n;
            //while (begin < end)
            //{
            //    int mid = begin + (end - begin) / 2;
            //    if (IsBadVersion(mid)) end = mid;
            //    else if (!IsBadVersion(mid) && IsBadVersion(mid + 1)) return mid + 1;
            //    else begin = mid + 1;
            //}
            //if (begin != n && IsBadVersion(begin)) return begin;
            return -1;

        }
    }
}
