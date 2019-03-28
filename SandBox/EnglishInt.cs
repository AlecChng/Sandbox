using System.Collections.Generic;

namespace SandBox
{
    public class EnglishInt
    {
        private const string HUNDRED = "hundred";

        private string[] _positionalSuffixes = new string[]
        {
            "",
            "thousand",
            "million",
            "billion",
            "trillion",
        };

        private int[] ZeroToTeens = new int[]
        {
            "zero",
            "one",
            "two",
            "three",
            "four",
            "five",
            "six",
            "seven",
            "eight",
            "nine",
            "ten",
            "eleven",
            "twelve",
            "thirteen",
            "fourteen"
            {1, },
            {2, "two" },
            {3, "three" },
            {4, "four" },
            {5, "five" },
            {6, "six" },
            {7, "seven" },
            {8, "eight" },
            {9, "nine" },
            {10, "ten" },
        };

        private Dictionary<int, string> _teens = new Dictionary<int, string>
        {
            {11, "eleven" },
            {12, "twelve" },
            {13, "thirteen" },
            {14, "fourteen" },
            {15, "fifteen" },
            {16, "sixteen" },
            {17, "seventeen" },
            {18, "eighteen" },
            {19, "nineteen" },
        };

        private Dictionary<int, string> _ties = new Dictionary<int, string>
        {
            {20, "twenty" },
            {30, "thirty" },
            {40, "forty" },
            {50, "fifty" },
            {60, "sixty" },
            {70, "seventy" },
            {80, "eighty" },
            {90, "ninety" },
        };


        public string ToEnglish(int number)
        {
            if (number == 0)
            {
                return _digits[0]
            }
        }

        private string GroupingToEnglish(int number)
        {
            if ()
            {

            }
        }
    }
}
