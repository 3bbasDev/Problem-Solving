using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Pair
{
    public static class PairAlgo
    {

        //[DllImport("Pairs", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        //static extern int ValidateImageColourInterop(ref int[] arr, ref int sum);


        //public bool Validate()
        //{
        //    // ...

        //    int rc = ValidateImageColourInterop(new int[] { 1,2,3,4,5},9);

        //    // ...
        //}


        public static int[] PairSum(int[] array, int target)
        {
            HashSet<int> hashSet = new HashSet<int>();
            int[] result = new int[2];

            for (int i = 0; i < array.Length; i++)
            {
                int x = target - array[i];
                if (hashSet.FirstOrDefault(f => f == x) != hashSet.LastOrDefault())
                {
                    result[0] = x;
                    result[1] = array[i];
                    return result;
                }
                hashSet.Add(array[i]);
            }
            return result;
        }

        public static int[] PairSum_Index(int[] array, int target)
        {
            int s = 0;
            int e = array.Length - 1;

            while (s < e)
            {
                int curent = array[s] + array[e];
                if (curent == target)
                    return new int[] { s + 1, e + 1 };
                else if (curent > target)
                    e--;
                else
                    s++;
            }
            return new int[] { };
        }
    }
}
