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

            int endVal = arr[end];
            if (endVal == end)
            {
                return end;
            }
            else if ((endVal < end && endVal < start) || (start == end && endVal != end))
            {
                return -1;
            }

            if (endVal < end && endVal >= start)
            {
                end = endVal + 1;
            }
            int mid = (start + end) / 2;

            var rightMagic = FindMagicIndexDivConqHelper(arr, mid + 1, end - 1);
            if (rightMagic >= 0)
            {
                return rightMagic;
            }

            var leftMagic = FindMagicIndexDivConqHelper(arr, start, mid);
            return leftMagic;
        }
    }
}
