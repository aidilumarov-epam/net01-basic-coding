using System;
using BasicCoding.Common;

namespace BasicCoding.Tasks
{
    public class NearestLargerNumberFinder
    {
        private const int NoSuchNumber = -1;

        /// <summary>
        /// Returns a nearest larger integer that contains the same digits
        /// </summary>
        /// <param name="number">Integer number to process</param>
        /// <returns>Nearest larger number or -1 if no such number exists</returns>
        public int FindNearestLargerNumber(int number)
        {
            var digits = number.GetDigits();

            if (digits.IsSorted(ascending: false))
            {
                return NoSuchNumber;
            }

            if (digits.IsSorted(ascending: true))
            {
                int swap = digits.Length - 1;
                int with = digits.Length - 2;
                for (int i = swap - 1; i >= 0; i--)
                {
                    if (digits[i] < digits[swap])
                    {
                        swap = i + 1;
                        with = i;
                    }
                }

                digits.Swap(swap, with);
                return digits.ToSingleInteger();
            }

            return ProcessFromRightToLeft(digits);
        }


        private int ProcessFromRightToLeft(int[] arr)
        {
            // Find a digit that is smaller than the previous
            for (int i = arr.Length - 1; i > 0; i--)
            {
                int smallerThanPrevCandidateIndex = i - 1;

                // If such number is found
                if (arr[i] > arr[smallerThanPrevCandidateIndex])
                {
                    int indexOfLarger = i;
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[j] < arr[indexOfLarger] && arr[j] > arr[smallerThanPrevCandidateIndex])
                        {
                            indexOfLarger = j;
                        }
                    }

                    arr.Swap(smallerThanPrevCandidateIndex, indexOfLarger);
                    Array.Sort(arr, smallerThanPrevCandidateIndex + 1, arr.Length - smallerThanPrevCandidateIndex - 1); ;

                    return arr.ToSingleInteger();
                }
            }

            // If no digit is smaller than the previous
            return NoSuchNumber;
        }
    }
}
