using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoding.Tasks
{
    public class StringConcatenator
    {
        /// <summary>
        /// Concatenates a string with the second one 
        /// and ignores the characters that are already present in the first string
        /// </summary>
        /// <param name="first">Original string</param>
        /// <param name="second">String to concatenate with</param>
        /// <returns>Concatenated string</returns>
        public string Concatenate(string first, string second)
        {
            var concatenated = new StringBuilder(first);
            var charDict = new Dictionary<char, bool>(capacity: first.Length);

            foreach (var c in first)
            {
                if (charDict.ContainsKey(c)) continue;

                charDict.Add(c, true);
            }

            foreach (var c in second)
            {
                if (charDict.ContainsKey(c)) continue;

                concatenated.Append(c);
            }

            return concatenated.ToString();
        }
    }
}
