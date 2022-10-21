using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public static class MoveZeroAlgo
    {
        public static void MoveZeros(HashSet<int> m)
        {
            int count = 0;
            for (int i = 0; i < m.Count; i++)
            {
                if (m.ElementAt(i) == 0)
                {
                    count++;
                    //deleting the element from vector
                    m.Remove(m.First() + i);
                    i--;
                }
            }

            for (int i = 0; i < count; i++)
            {
                //inserting the zero into vector
                m.Add(0);
            }
        }

        public static void pushZerosToEnd(int[] arr, int n)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
                if (arr[i] != 0)
                    arr[count++] = arr[i];

            while (count < n)
                arr[count++] = 0;
        }
    }
}
