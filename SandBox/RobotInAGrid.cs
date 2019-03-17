using System.Collections.Generic;

namespace SandBox
{
    public class RobotInAGrid
    {
        public LinkedList<(int XCoord, int YCoord)> FindRobotPath(bool[,] grid)
        {
            var path = new LinkedList<(int XCoord, int YCoord)>();
            FindRobotPathHelper(grid, 0, 0, path);
            return path;
        }

        private bool FindRobotPathHelper(bool[,] grid, int xCoord, int yCoord, LinkedList<(int XCoord, int YCoord)> path)
        {
            var numRows = grid.GetLength(0);
            var numCols = grid.GetLength(1);
            // Index Out of Bound
            if (xCoord >= numCols || yCoord >= numRows)
            {
                return false;
            }

            var validCell = grid[xCoord, yCoord];
            if (!validCell)
            {
                return false;
            }
            else if (xCoord == numCols - 1 && yCoord == numRows - 1)
            {
                path.AddLast((xCoord, yCoord));
                return true;
            }
            else
            {
                var validPath = FindRobotPathHelper(grid, xCoord + 1, yCoord, path);
                if (validPath)
                {
                    path.AddFirst((xCoord, yCoord));
                }
                else
                {
                    validPath = FindRobotPathHelper(grid, xCoord, yCoord + 1, path);
                    if (validPath)
                    {
                        path.AddFirst((xCoord, yCoord));
                    }
                }

                return validPath;
            }
        }
    }
}
