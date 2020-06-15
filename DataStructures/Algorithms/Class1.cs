


using System;
using System.Collections.Generic;
/**
* Definition for a binary tree node.
* public class TreeNode {
*     public int val;
*     public TreeNode left;
*     public TreeNode right;
*     public TreeNode(int x) { val = x; }
* }
*/
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
    public class LevelOrderTraversal
    {
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            IList<IList<int>> tree = new List<IList<int>>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            if (root == null)
            {
                return tree;
            }
            TreeNode empty = new TreeNode(0);

            IList<int> levelList = new List<int>();
            queue.Enqueue(root);
            queue.Enqueue(null);
            int zigzag = 0;

            while (queue.Count > 0)
            {
                root = queue.Peek();
                if (root != null)
                {
                    Console.WriteLine("value of root" + root.val);
                    if (zigzag == 0)
                    {
                        if (root.right != null)
                            queue.Enqueue(root.right);



                        if (root.left != null)
                            queue.Enqueue(root.left);

                    }
                    else
                    {

                        if (root.left != null)
                            queue.Enqueue(root.left);


                        if (root.right != null)
                            queue.Enqueue(root.right);


                    }



                    levelList.Add(root.val);
                    root = queue.Dequeue();
                }
                else
                {
                    zigzag = zigzag == 1 ? 0 : 1;
                    Console.WriteLine("Queue when null is reached " + queue.Count);
                    root = queue.Dequeue();
                    tree.Add(levelList);
                    levelList = new List<int>();
                    if (queue.Count > 0)
                        queue.Enqueue(null);

                }

            }


            return tree;
        }
    }
}