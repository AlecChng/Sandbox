using System.Collections.Generic;

namespace SandBox
{
    public class Paren
    {
        // Fails for ParenGen(4) does not generate (())(())
        public HashSet<string> ParenGen(int numParens)
        {
            var parens = new HashSet<string>();
            if (numParens <= 0)
            {
                parens.Add("");
            }
            else
            {
                var oneLessParens = ParenGen(numParens - 1);
                foreach (var permutation in oneLessParens)
                {
                    parens.Add("(" + permutation + ")");
                    parens.Add("()" + permutation);
                    parens.Add(permutation + "()");
                }
            }

            return parens;
        }

        public List<string> ParenGenOptimized(int numParens)
        {
            var parens = new List<string>();
            var parenChars = new char[2 * numParens];

            ParenGenOptimizedHelper(parens, numParens, numParens, parenChars, 0);

            return parens;
        }

        private void ParenGenOptimizedHelper(List<string> parens, int remainingLeftParen, int remainingRightParen, char[] parenChars, int parenCharsIndex)
        {
            if (remainingLeftParen < 0 || remainingRightParen < 0 || remainingRightParen < remainingLeftParen)
            {
                return;
            }
            else if (remainingLeftParen == 0 && remainingRightParen == 0)
            {
                parens.Add(string.Join("", parenChars));
            }
            else
            {
                parenChars[parenCharsIndex] = '(';
                ParenGenOptimizedHelper(parens, remainingLeftParen - 1, remainingRightParen, parenChars, parenCharsIndex + 1);

                parenChars[parenCharsIndex] = ')';
                ParenGenOptimizedHelper(parens, remainingLeftParen, remainingRightParen - 1, parenChars, parenCharsIndex + 1);
            }
        }

        public HashSet<string> ParenGenSolution(int numParens)
        {
            HashSet<string> set = new HashSet<string>();
            if (numParens == 0)
            {
                set.Add("");
            }
            else
            {
                var prev = ParenGenSolution(numParens - 1);
                foreach (string str in prev)
                {
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (str[i] == '(')
                        {
                            string s = insertInside(str, i);
                            set.Add(s);
                        }
                    }
                    set.Add("()" + str);
                }
            }
            return set;
        }

        private string insertInside(string str, int leftIndex)
        {
            string left = Substring(str, 0, leftIndex + 1);
            string right = Substring(str, leftIndex + 1, str.Length);

            return left + "()" + right;
        }

        private string Substring(string str, int startIndex, int endIndex)
        {
            int length = endIndex - startIndex;
            return str.Substring(startIndex, length);
        }
    }
}
