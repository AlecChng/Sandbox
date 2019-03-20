using System;
using System.Collections.Generic;

namespace SandBox
{
    public class Permutations
    {
        public List<string> FindAllPermutations(string srcString)
        {
            var perms = new List<string>();
            if (srcString == null || srcString.Length == 0)
            {
                perms.Add(string.Empty);
                return perms;
            }
            else
            {
                for (int i = 0; i < srcString.Length; i++)
                {
                    var prefix = srcString[i];
                    var remaining = srcString.Remove(i, 1);
                    var permOfRemaining = FindAllPermutations(remaining);
                    foreach (var permuation in permOfRemaining)
                    {
                        perms.Add(prefix + permuation);
                    }
                }
            }
            return perms;
        }

        public HashSet<string> FindAllPermutationsDeDupBruteForce(string srcString)
        {
            var perms = new HashSet<string>();
            if (srcString == null || srcString.Length == 0)
            {
                perms.Add(string.Empty);
                return perms;
            }
            else
            {
                for (int i = 0; i < srcString.Length; i++)
                {
                    var prefix = srcString[i];
                    var remaining = srcString.Remove(i, 1);
                    var permOfRemaining = FindAllPermutationsDeDupBruteForce(remaining);
                    foreach (var permuation in permOfRemaining)
                    {
                        perms.Add(prefix + permuation);
                    }
                }
            }
            return perms;
        }

        private List<string> FindAllPermutationsDeDupMemoizationHelper(string sortedSrcString, HashSet<string> cache)
        {
            var perms = new List<string>();
            if (sortedSrcString == null || sortedSrcString.Length == 0)
            {
                perms.Add(string.Empty);
                return perms;
            }
            else
            {
                for (int i = 0; i < sortedSrcString.Length; i++)
                {
                    var prefix = sortedSrcString[i];
                    var remaining = sortedSrcString.Remove(i, 1);
                    if (cache.Add(prefix + remaining))
                    {
                        var permOfRemaining = FindAllPermutationsDeDupMemoizationHelper(remaining, cache);
                        foreach (var permutation in permOfRemaining)
                        {
                            perms.Add(prefix + permutation);
                        }
                    }
                }
            }

            return perms;
        }


        public List<string> FindAllPermutationsDeDupMemoization(string srcString)
        {
            if (srcString == null || srcString.Length == 0)
            {
                return new List<string>();
            }

            var srcChars = srcString.ToCharArray();
            Array.Sort(srcChars);

            var cache = new HashSet<string>();
            var sortedSrcString = new string(srcChars);

            return FindAllPermutationsDeDupMemoizationHelper(srcString, cache);
        }
    }
}
