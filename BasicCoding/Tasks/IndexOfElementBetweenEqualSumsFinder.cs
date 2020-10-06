using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;

namespace BasicCoding.Tasks
{
    public class IndexOfElementBetweenEqualSumsFinder
    {
        private const double floatComparisonAcceptedDelta = 0.00001d;
        private const int indexDoesNotExist = -1;

        /// <summary>
        /// Returns an index of an element that divides two halves with equal sums
        /// </summary>
        /// <param name="arr">Array of doubles</param>
        /// <returns>Index of the element or -1 if no such item is found</returns>
        public int FindIndex_Naive(double[] arr)
        {

            // Array should contain at least 3 elements
            if (arr.Length <= 2)
            {
                return indexDoesNotExist;
            }

            var middleIndex = 1;

            var leftSum = 0d;
            var rightSum = 0d;

            while (middleIndex < arr.Length - 1)
            {
                for (int i = 0; i < middleIndex; i++)
                {
                    leftSum += arr[i];
                }

                for (int i = middleIndex + 1; i < arr.Length; i++)
                {
                    rightSum += arr[i];
                }

                if (Math.Abs(leftSum - rightSum) < floatComparisonAcceptedDelta)
                {
                    return middleIndex;
                }

                leftSum = 0.0d;
                rightSum = 0.0d;
                middleIndex++;
            }

            return indexDoesNotExist;
        }

        // <summary>
        /// Returns an index of an element that divides two halves with equal sums
        /// </summary>
        /// <param name="arr">Array of doubles</param>
        /// <returns>Index of the element or -1 if no such item is found</returns>
        public int FindIndex_Optimized(double[] arr)
        {
            // Array should contain at least 3 elements
            if (arr.Length <= 2)
            {
                return indexDoesNotExist;
            }

            var middleIndex = 1;

            var leftSum = 0d;
            var rightSum = 0d;

            for (int i = 0; i < middleIndex; i++)
            {
                leftSum += arr[i];
            }

            for (int i = middleIndex + 1; i < arr.Length; i++)
            {
                rightSum += arr[i];
            }

            while (middleIndex < arr.Length - 1)
            {
                if (Math.Abs(leftSum - rightSum) < floatComparisonAcceptedDelta)
                {
                    return middleIndex;
                }

                leftSum += arr[middleIndex];
                rightSum -= arr[middleIndex + 1];
                middleIndex++;
            }

            return indexDoesNotExist;
        }
    }
}
