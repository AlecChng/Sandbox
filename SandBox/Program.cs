namespace SandBox
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // # TripleStep
            //var tripleStep = new TripleStep();
            //var recursionOnly = tripleStep.TripleStepRecursionOnly(6);
            //var dynamicProgramming = tripleStep.TripleStepDynamicProgramming(6);
            //var memoization = tripleStep.TripleStepMemoization(6);

            // # RobotInAGrid
            //var robotInAGrid = new RobotInAGrid();
            // All off limts
            //var grid = new bool[2, 2]; 

            // 0,0 -> 1,0 -> 1,1 
            //var grid = new bool[,]
            //{
            //    { true, true },
            //    { true, true }
            //};

            // 0,0 -> 0,1 -> 1,1
            //var grid = new bool[,]
            //{
            //    { true, true },
            //    { true, true }
            //};
            //grid[1, 0] = false;


            //var grid = new bool[4, 4];
            //SetAllTrue(grid);
            //grid[1, 1] = false;
            //grid[2, 1] = false;
            //grid[3, 1] = false;
            //grid[2, 3] = false;

            //var path = robotInAGrid.FindRobotPath(grid);


            // # FindMagicIndex
            var arr = new int[] { 0, 0, 0, 2, 3, 5, 7, 8 };
            //var arr = new int[] { 0, 0, 0, 2, 3, 3, 7, 8 };s
            //var arr = new int[] { 0, 1, 1, 2, 3, 3, 7, 8 };


            var magicIndexFinder = new FindMagicIndex();
            var magicIndex = magicIndexFinder.FindMagicIndexDivConq(arr);
        }

        private static void SetAllTrue(bool[,] grid)
        {
            for (var row = 0; row < grid.GetLength(0); row++)
            {
                for (var col = 0; col < grid.GetLength(1); col++)
                {
                    grid[row, col] = true;
                }
            }
        }
    }
}
