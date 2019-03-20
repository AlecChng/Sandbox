namespace SandBox
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var trailingZerosCalc = new TrailingZeros();

            //var factorial = 20;
            //var brute = trailingZerosCalc.TrailingZerosBruteForce(factorial);
            //var optimized = trailingZerosCalc.TrailingZerosOptimized(factorial);


            var pondFinder = new PondSizes();

            var grid = new int[,]
                {
                    {0, 2, 1, 0 },
                    {0, 1, 0, 1 },
                    {1, 1, 0, 1 },
                    {0, 1, 0, 1 }
                };

            var sizes = pondFinder.GetAllPondSizes(grid);
        }
    }
}
