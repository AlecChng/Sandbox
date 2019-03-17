using System.Collections.Generic;

namespace SandBox
{
    public class Program
    {
        public const int CAP_BASE_DEC = 65;
        public const int MAX_ALPHABET_COUNT = 26;

        public static void Main(string[] args)
        {
            var test = "abcd";
            char testa = test[0];
            //var isUnique = IsUniqueWithDict("abcd");
            //var notUnique = IsUniqueWithDict("abcadj");

            var isUnique = IsUnique("abcd");
            var notUnique = IsUnique("abcadj");
        }

        /// <summary>
        /// 1.1 Determine if a string has all unique characters. Implementation with dictionary data structure.
        /// </summary>
        /// <param name="sourceString"></param>
        /// <returns></returns>
        public static bool IsUniqueWithDict(string sourceString)
        {
            if (sourceString.Length > MAX_ALPHABET_COUNT)
            {
                return false;
            }

            var charDict = new Dictionary<char, int>();

            for (int charIndex = 0; charIndex < sourceString.Length; charIndex++)
            {
                var curChar = sourceString[charIndex];
                if (charDict.ContainsKey(curChar))
                {
                    charDict[curChar] += 1;
                }
                else
                {
                    charDict.Add(curChar, 1);
                }
            }

            var uniqueChars = true;
            foreach (var charCount in charDict.Values)
            {
                if (charCount > 1)
                {
                    uniqueChars = false;
                    break;
                }
            }

            return uniqueChars;
        }

        /// <summary>
        /// 1.1 Determine if a string has all unique characters. Implementation with no data structures.
        /// </summary>
        /// <param name="sourceString"></param>
        /// <returns></returns>
        public static bool IsUnique(string sourceString)
        {
            // String cannot be unique if it has more than 26 characters
            if (sourceString.Length > MAX_ALPHABET_COUNT)
            {
                return false;
            }

            var lowerString = sourceString.ToUpper();
            int charBitVector = 0;
            var unique = true;


            for (int charIndex = 0; charIndex < lowerString.Length && unique; charIndex++)
            {
                var curChar = lowerString[charIndex];
                var bitIndex = curChar % CAP_BASE_DEC;

                var bitMask = 1 << bitIndex;
                var bitValue = charBitVector & bitMask;

                if (bitValue > 0)
                {
                    unique = false;
                }
                else
                {
                    charBitVector = charBitVector | bitMask;
                }

            }

            return unique;
        }
    }
}
