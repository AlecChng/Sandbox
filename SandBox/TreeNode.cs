using System.Collections.Generic;

namespace SandBox
{
    public class BinaryTreeNode
    {
        public int Value { get; set; }
        public BinaryTreeNode Left { get; set; }
        public BinaryTreeNode Right { get; set; }

        public BinaryTreeNode(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }

        #region Cracking the Coding Interview: 4.2
        /// <summary>
        /// Get the minimal binary search tree given a sorted array of unique integers
        /// </summary>
        /// <param name="elements"></param>
        /// <returns></returns>
        public static BinaryTreeNode GetMinimalBST(List<int> elements)
        {
            BinaryTreeNode root = null;
            if (elements.Count == 1)
            {
                root = new BinaryTreeNode(elements[0]);
            }
            else
            {
                root = GetMinimalBSTHelper(elements, 0, elements.Count - 1);
            }

            return root;
        }

        private static BinaryTreeNode GetMinimalBSTHelper(List<int> elements, int start, int end)
        {
            if (start == end)
            {
                return new BinaryTreeNode(elements[start]);
            }
            else if (end < start)
            {
                return null;
            }
            else
            {
                int midpointIndex = (start + end) / 2;

                BinaryTreeNode currRoot = new BinaryTreeNode(elements[midpointIndex]);

                currRoot.Left = GetMinimalBSTHelper(elements, start, midpointIndex - 1);
                currRoot.Right = GetMinimalBSTHelper(elements, midpointIndex + 1, end);

                return currRoot;
            }
        }
        #endregion

        #region Cracking the Coding Interview: 4.3
        public static Dictionary<int, LinkedList<BinaryTreeNode>> GetNodesPerDepth(BinaryTreeNode binaryTree)
        {
            var nodesPerDepth = new Dictionary<int, LinkedList<BinaryTreeNode>>();

            GetNodesPerDepth(binaryTree, 0, nodesPerDepth);

            return nodesPerDepth;
        }

        private static void GetNodesPerDepth(BinaryTreeNode node, int depth, Dictionary<int, LinkedList<BinaryTreeNode>> nodesPerDepth)
        {
            if (node != null)
            {
                if (!nodesPerDepth.ContainsKey(depth))
                {
                    nodesPerDepth[depth] = new LinkedList<BinaryTreeNode>();
                }

                nodesPerDepth[depth].AddLast(node);
                GetNodesPerDepth(node.Left, depth + 1, nodesPerDepth);
                GetNodesPerDepth(node.Right, depth + 1, nodesPerDepth);
            }
        }
        #endregion  
    }
}
