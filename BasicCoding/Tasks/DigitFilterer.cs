using System;
using System.Collections.Generic;
using BasicCoding.Common;

namespace BasicCoding.Tasks
{
    public class DigitFilterer
    {
        /// <summary>
        /// Filters numbers and returns an array that contains only the elements that have a certain digit inside
        /// </summary>
        /// <param name="numbers">Array to filter</param>
        /// <param name="filterWith">Digit to filter with</param>
        /// <returns>Filtered array</returns>
        public int[] Filter(int[] numbers, int filterWith)
        {
            var filteredList = new List<int>();

            foreach (var num in numbers)
            {
                var digits = num.GetDigits();

                foreach(var digit in digits)
                {
                    if (Math.Abs(digit) == filterWith)
                    {
                        filteredList.Add(num);
                        break;
                    }
                }
            }

            return filteredList.ToArray();
        }
    }
}
