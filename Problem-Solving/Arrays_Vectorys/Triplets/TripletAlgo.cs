using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triplets
{
    public static class TripletAlgo
    {
        public static HashSet<int[]> GetTriplets(int[] arr, int n, int target)
        {
            Array.Sort(arr);
            HashSet<int[]> triplets = new HashSet<int[]>();
            for (int i = 0; i <= n - 3; i++)
            {
                int j = i + 1;
                int k = n - 1;
                while (j < k)
                {
                    int curentNumber = arr[i];
                    curentNumber += arr[j];
                    curentNumber += arr[k];

                    if (curentNumber == target)
                    {
                        triplets.Add(new int[] { arr[i], arr[j], arr[k] });
                        j++;
                        k--;
                    }
                    else if (curentNumber > target)
                        k--;
                    else j++;
                }

            }
            return triplets;
        }
    }
}
