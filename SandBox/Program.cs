using System;
using System.Collections.Generic;

namespace SandBox
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var minHeap = new MinHeap(10);
            minHeap.Insert(6);
            minHeap.Insert(5);
            minHeap.Insert(4);
            minHeap.Insert(3);
            minHeap.Insert(2);
            minHeap.Insert(1);

            var min = minHeap.Remove();
            var min1 = minHeap.Remove();

            var tempList = new List<int> { 3, 4, 2 }.ToArray();
            Array.Sort(tempList);
            var test = new Random().Next();
        }
    }
}
