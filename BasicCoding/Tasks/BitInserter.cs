using System;
using System.Collections;

namespace BasicCoding.Tasks
{
    public class BitInserter
    {
        /// <summary>
        /// Insert a number of bits from numberIn to numberSource
        /// </summary>
        /// <param name="numberSource">Number to insert into</param>
        /// <param name="numberIn">Number to insert from</param>
        /// <param name="i">Least significant bit to start from</param>
        /// <param name="j">Most significant bit to end with</param>
        /// <returns>Result of insertion</returns>
        public int InsertNumber(int numberSource, 
            int numberIn, int i, int j)
        {
            var firstNumberInBits = new BitArray(BitConverter.GetBytes(numberSource));
            var secondNumberInBits = new BitArray(BitConverter.GetBytes(numberIn));

            var indexForSecondNum = 0;

            while (i <= j)
            {
                firstNumberInBits[i++] = secondNumberInBits[indexForSecondNum++];
            }

            return bitArrayToInt(firstNumberInBits);
        }

        private int bitArrayToInt(BitArray bitArray)
        {
            if (bitArray.Length > 32)
            {
                throw new ArgumentException("Int can store at most 32 bits");
            }

            int[] intArr = new int[1];
            bitArray.CopyTo(intArr, 0);

            return intArr[0];
        }
    }
}
