using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchInsertPosition
{
    public class SearchInsertPositionAlgo
    {
        public int FindIndex(int[] arr, int s, int e, int K)
        {

            while (s <= e)
            {
                int mid = (s + e) / 2;

                if (arr[mid] == K)
                    return mid;

                else if (arr[mid] < K)
                    return FindIndex(arr, mid + 1, e, K);

                else
                    return FindIndex(arr, s, mid - 1, K);
            }

            return e + 1;
        }

    }
}
