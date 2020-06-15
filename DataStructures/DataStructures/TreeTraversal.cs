using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    
 // Definition for a binary tree node.
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    class TreeTraversal
    {
        IList<int> traversal = new List<int>();
        public IList<int> PreorderTraversal(TreeNode root)
        {

            if (root == null)
                return traversal;
            Traversal(root);
            return traversal;
        }
        public void Traversal(TreeNode root)
        {
            if (root != null)
            {
                traversal.Add(root.val);
                Traversal(root.left);
                Traversal(root.right);
            }
        }
    }
}
