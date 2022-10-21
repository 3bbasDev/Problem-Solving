using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public static class SquaresOfSortedArray
    {
        public static int[] SortedSquares(int[] nums)
        {
            int[] hash = new int[nums.Length];
            int[] result = new int[nums.Length];
            int x = 0;
            int y = 0;
            for (int i = 0; i < nums.Length; i++)
                hash[i] = (nums[i] * nums[i]);
            for (int i = 0; i < hash.Length; i++)
            {
                x = nums[i];
                for (int j = i + 1; j < hash.Length; j++)
                {
                    if (x < nums[j])
                    {
                        x = nums[j];
                        y = hash[i];
                        hash[i] = nums[j];
                        nums[j] = y;
                    }
                }
                result[i] = x;
            }
            return result;
        }

        public static int[] NEWSORT(int[] arr)
        {
            int n = arr.Length, left = 0,
                right = n - 1;
            int[] result = new int[n];

            for (int index = n - 1; index >= 0; index--)
            {
                if (Math.Abs(arr[left]) > arr[right])
                {
                    result[index] = arr[left] * arr[left];
                    left++;
                }
                else
                {
                    result[index] = arr[right] * arr[right];
                    right--;
                }
            }
            for (int i = 0; i < n; i++)
                arr[i] = result[i];

            return arr;
        }

        /*
         * // Function to exchange data of two given indices in an array
static void swap(int[] A, int i, int j)
{
    int data = A[i];
    A[i] = A[j];
    A[j] = data;
}

// Function to reverse a given subarray
static void reverse(int[] A, int low, int high)
{
    for (int i = low, j = high; i < j; i++, j--)
    {
        swap(A, i, j);
    }
}

// Function to right-rotate an array by `k` positions
static void rightRotateReves(int[] A, int k, int n)
{
    // base case: invalid input
    if (k < 0 || k >= n)
    {
        return;
    }

    // Reverse the last `k` elements
    reverse(A, n - k, n - 1);

    // Reverse the first `n-k` elements
    reverse(A, 0, n - k - 1);

    // Reverse the whole array
    reverse(A, 0, n - 1);
}

// Function to right-rotate an array by `k` positions
static void rightRotateNEW(int[] A, int k)
{
    int n = A.Length;

    // base case: invalid input
    if (k < 0 || k >= n)
    {
        return;
    }

    // construct an auxiliary array of size `k` and
    // fill it with the last `k` elements of the input array
    int[] aux = new int[k];
    for (int i = 0; i < k; i++)
    {
        aux[i] = A[n - k + i];
    }

    // shift the first `n-k` elements of the input array at the end
    for (int i = n - k - 1; i >= 0; i--)
    {
        A[i + k] = A[i];
    }

    // put the elements of the auxiliary array at their
    // correct positions in the input array
    for (int i = 0; i < k; i++)
    {
        A[i] = aux[i];
    }
}


static void rightRotateByOne(int[] A)
{
    int last = A[A.Length - 1];
    for (int i = A.Length - 2; i >= 0; i--)
    {
        A[i + 1] = A[i];
    }

    A[0] = last;
}

// Function to right-rotate an array by `k` positions
static void rightRotate(int[] A, int k)
{
    // base case: invalid input
    if (k < 0 || k >= A.Length)
    {
        return;
    }

    for (int i = 0; i < k; i++)
    {
        rightRotateByOne(A);
    }
}
         */
    }
}
