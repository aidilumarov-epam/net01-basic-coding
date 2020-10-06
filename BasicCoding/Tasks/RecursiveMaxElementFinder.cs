using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoding.Tasks
{
    public class RecursiveMaxElementFinder
    {
        /// <summary>
        /// Returns the largest element in the array
        /// </summary>
        /// <param name="arr">Array of integers</param>
        /// <returns>The largest element</returns>
        public int FindMaxElement(int[] arr)
        {
            return findMaxElement(arr, arr.Length);
        }

        private int findMaxElement(int[] arr, int i)
        {
            if (i == 1)
            {
                return arr[0];
            }

            return Math.Max(arr[i - 1], findMaxElement(arr, i - 1));
        }
    }
}
