using System;

namespace SandBox
{
    public class Program
    {
        private static int NodeValue = 0;
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //var elements = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var minimalBST = BinaryTreeNode.GetMinimalBST(elements);

            var sampleBinTree = GetSampleBinaryTree(2);
            var nodesPerDepth = BinaryTreeNode.GetNodesPerDepth(sampleBinTree);

        }

        private static BinaryTreeNode GetSampleBinaryTree(int depth)
        {
            if (depth == 0)
            {
                return new BinaryTreeNode(NodeValue);
            }
            else
            {
                var curBinaryTree = new BinaryTreeNode(NodeValue);
                NodeValue++;
                curBinaryTree.Left = GetSampleBinaryTree(depth - 1);
                NodeValue++;
                curBinaryTree.Right = GetSampleBinaryTree(depth - 1);

                return curBinaryTree;
            }
        }

    }
}
