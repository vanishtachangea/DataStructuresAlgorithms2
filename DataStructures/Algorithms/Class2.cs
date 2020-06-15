using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    /**
     * Definition for a binary tree node.
     * public class TreeNode {
     *     public int val;
     *     public TreeNode left;
     *     public TreeNode right;
     *     public TreeNode(int x) { val = x; }
     * }
     */
    public class Solution
    {
        public bool IsValidBST(TreeNode root)
        {
            return DFSInOrderTraversal(root, null, null);
        }
        public bool DFSInOrderTraversal(TreeNode root, TreeNode left, TreeNode right)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            //bool inOrder = false;
            if (root == null)
            {
                return true;
            }
            stack.Push(root);

            DFSInOrderTraversal(root.left, null, null);
            Console.WriteLine(root.val);
            TreeNode x = stack.Pop();
            Console.WriteLine("From Stack " + x.val);

            DFSInOrderTraversal(root.right, null, null);
            return true;
        }
    }
}
