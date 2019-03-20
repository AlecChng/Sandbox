using System;

namespace SandBox
{
    public class FindMagicIndex
    {
        public int FindMagicIndexDivConq(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                return -1;
            }

            return FindMagicIndexDivConqHelper(arr, 0, arr.Length - 1);
        }

        private int FindMagicIndexDivConqHelper(int[] arr, int start, int end)
        {
            if (start > end)
            {
                return -1;
            }

            int midIndex = (start + end) / 2;
            int midVal = arr[midIndex];
            if (midVal == midIndex)
            {
                return midIndex;
            }

            var leftIndex = Math.Min(midIndex - 1, midVal);
            var leftMagic = FindMagicIndexDivConqHelper(arr, start, leftIndex);
            if (leftMagic >= 0)
            {
                return leftMagic;
            }

            var rightIndex = Math.Max(midIndex + 1, midVal);
            var rightMagic = FindMagicIndexDivConqHelper(arr, rightIndex, end);
            return rightMagic;
        }
    }
}
