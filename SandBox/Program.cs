namespace SandBox
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var tripleStep = new TripleStep();
            var recursionOnly = tripleStep.TripleStepRecursionOnly(6);
            var dynamicProgramming = tripleStep.TripleStepDynamicProgramming(6);
            var memoization = tripleStep.TripleStepMemoization(6);
        }
    }
}
