using BasicCoding.Tasks;
using System;

namespace BasicCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            var filterer = new DigitFilterer();
            var result = filterer.Filter(new int[] { 7, 1, 2, 3, 4, 5, 6, 7, 68, -69, 70, 15, 17 }, 9);

            Console.WriteLine(result);
        }
    }
}
