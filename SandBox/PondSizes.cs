using System.Collections.Generic;

namespace SandBox
{
    /// <summary>
    /// 16.19
    /// </summary>
    public class PondSizes
    {
        public List<int> GetAllPondSizes(int[,] grid)
        {
            var pondSizes = new List<int>();
            for (int row = 0; row < grid.GetLength(1); row++)
            {
                for (int col = 0; col < grid.GetLength(0); col++)
                {
                    var curCell = grid[row, col];
                    if (curCell == 0)
                    {
                        pondSizes.Add(GetPondSize(row, col, grid));
                    }
                }
            }
            return pondSizes;
        }

        public int GetPondSize(int row, int col, int[,] grid)
        {
            if (row < 0 || col < 0 || row >= grid.GetLength(1) || col >= grid.GetLength(0))
            {
                return 0;
            }

            var curCell = grid[row, col];
            if (curCell != 0)
            {
                return 0;
            }
            else
            {
                var pondSize = 1;
                grid[row, col] = -1;
                pondSize += GetPondSize(row, col + 1, grid);
                pondSize += GetPondSize(row + 1, col, grid);
                pondSize += GetPondSize(row, col - 1, grid);
                pondSize += GetPondSize(row - 1, col, grid);
                pondSize += GetPondSize(row + 1, col + 1, grid);
                pondSize += GetPondSize(row - 1, col - 1, grid);
                pondSize += GetPondSize(row - 1, col + 1, grid);
                pondSize += GetPondSize(row + 1, col - 1, grid);

                return pondSize;
            }
        }
    }
}
