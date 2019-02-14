using System.Collections.Generic;

namespace SandBox
{
    /// <summary>
    /// Cracking the Coding Interview 8.1, Triple Step
    /// </summary>
    public class TripleStep
    {
        public int TripleStepRecursionOnly(int numSteps)
        {
            if (numSteps < 1)
            {
                return 0;
            }
            else if (numSteps == 1)
            {
                return 1;
            }
            else if (numSteps == 2)
            {
                return 2;
            }
            else if (numSteps == 3)
            {
                return 4;
            }
            else
            {
                return TripleStepRecursionOnly(numSteps - 1) + TripleStepRecursionOnly(numSteps - 2) + TripleStepRecursionOnly(numSteps - 3);
            }
        }

        public int TripleStepDynamicProgramming(int numSteps)
        {
            // Key = total steps, Value = number of permutations for reaching numSteps
            var memo = new Dictionary<int, int>
            {
                { 1, 1 },
                { 2, 2 },
                { 3, 4 }
            };

            return TripleStepDynamicProgrammingHelper(numSteps, memo);
        }
        private int TripleStepDynamicProgrammingHelper(int numSteps, Dictionary<int, int> memo)
        {
            if (numSteps < 1)
            {
                return 0;
            }
            else if (memo.ContainsKey(numSteps))
            {
                return memo[numSteps];
            }
            else
            {
                return TripleStepDynamicProgrammingHelper(numSteps - 1, memo) + TripleStepDynamicProgrammingHelper(numSteps - 2, memo) + TripleStepDynamicProgrammingHelper(numSteps - 3, memo);
            }
        }

        public int TripleStepMemoization(int numSteps)
        {
            var memo = new Dictionary<int, int>
            {
                { 1, 1 },
                { 2, 2 },
                { 3, 4 }
            };

            if (numSteps <= 0)
            {
                return 0;
            }
            else if (numSteps < 4)
            {
                return memo[numSteps];
            }

            for (int i = 4; i <= numSteps; i++)
            {
                memo[i] = memo[i - 1] + memo[i - 2] + memo[i - 3];
            }

            return memo[numSteps];
        }
    }
}
