using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoding.Common
{
    public static class IntegerUtils
    {
        public static int ToSingleInteger(this int[] arr)
        {
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                result *= 10;
                result += arr[i];
            }

            return result;
        }

        public static void Swap(this int[] arr, int swap, int with)
        {
            int temp = arr[swap];
            arr[swap] = arr[with];
            arr[with] = temp;
        }

        public static bool IsSorted(this int[] arr, bool ascending = true)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {

                bool condition;
                switch (ascending)
                {
                    case true:
                        condition = arr[i + 1] < arr[i];
                        break;
                    case false:
                        condition = arr[i + 1] > arr[i];
                        break;
                }

                if (condition)
                {
                    return false;
                }
            }

            return true;
        }

        public static int[] GetDigits(this int number)
        {
            var length = GetLength(number);
            var digits = new int[length];

            int nextIndex = length - 1;
            while (number != 0)
            {
                digits[nextIndex--] = number % 10;
                number /= 10;
            }

            return digits;
        }

        public static int GetLength(this int number)
        {
            return (int)Math.Floor(Math.Log10(Math.Abs(number))) + 1;
        }
    }
}
