using System;

namespace SandBox
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //var states = new int[] { 1, 0, 0, 0, 0, 1, 0, 0 };
            var states = new int[] { 1, 1, 1, 0, 1, 1, 1, 1 };
            
            var result = CellCompete(states, 2);
        }

        public static int[] CellCompete(int[] states, int days)
        {
            var leftCell = -1;
            var rightCell = -1;

            for (int currDay = 0; currDay < days; currDay++)
            {
                var nextDayStates = new int[states.Length];
                for (int cellIndex = 0; cellIndex < states.Length; cellIndex++)
                {
                    if (cellIndex == 0)
                    {
                        leftCell = 0;
                        rightCell = states[cellIndex + 1];
                    }
                    else if (cellIndex == states.Length - 1)
                    {
                        leftCell = states[cellIndex - 1];
                        rightCell = 0;
                    }
                    else
                    {
                        leftCell = states[cellIndex - 1];
                        rightCell = states[cellIndex + 1];
                    }

                    if (leftCell == rightCell)
                    {
                        nextDayStates[cellIndex] = 0;
                    }
                    else
                    {
                        nextDayStates[cellIndex] = 1;
                    }
                }
                states = nextDayStates;
            }

            return states;
        }
    }
}
