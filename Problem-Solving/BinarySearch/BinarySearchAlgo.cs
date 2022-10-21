using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public class BinarySearchAlgo
    {
        public int[] Numbers { get; }

        public BinarySearchAlgo(int[] numbers)
        {
            Numbers = numbers;
        }

        public int GetIndexTarget(int[] arr, int p, int r, int num)
        {
            if (p <= r)
            {
                int mid = (p + r) / 2;
                if (arr[mid] == num)
                    return mid;
                if (arr[mid] > num)
                    return GetIndexTarget(arr, p, mid - 1, num);
                if (arr[mid] < num)
                    return GetIndexTarget(arr, mid + 1, r, num);
            }
            return -1;
        }

        public int GetIndexTarget(int target)
        {
            int start = 0;
            int end = Numbers.Length - 1;
            int mid;

            while (start <= end)
            {
                mid = (start + end) / 2;

                if (Numbers[mid] == target)
                    return mid;
                else if (Numbers[mid] > target)
                    end = mid - 1;
                else start = mid + 1;
            }

            return -1;
        }
    }
}
