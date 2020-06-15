using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class BinarySearchTree
    {
        public Node root { get; set; }
        public BinarySearchTree()
        {
            this.root = null;
        }
        public void insert(int value)
        {
            //CodNoe here
            Node newNode = new Node(value);
            if (this.root == null)
                this.root = newNode;
            else
            {
                Node currNode = this.root;
                while(true)
                {
                    if(value < currNode.value)
                    {
                        //Left
                        if (currNode.left == null)
                        {
                            currNode.left = newNode;
                            break;
                        }
                        currNode = currNode.left;
                        
                        
                    }
                    else
                    {
                        //Right
                        if (currNode.right == null)
                        {
                            currNode.right = newNode;
                            break;
                        }
                        currNode = currNode.right;
                    }

                }
            }
        }
        public Node lookup(int value)
        {
            if (this.root == null)
                return null;
            Node currNode = this.root;
            while (currNode !=null)
            {

                if (currNode.value == value)
                {
                    break ;
                }
                else if (value < currNode.value)
                {
                    //Left
                    currNode = currNode.left;
                }
                else
                {
                    //Right
                    currNode = currNode.right;
                }

            }
            return currNode;
        }
        public void remove(int value)
        {
           if(this.root!=null)
           {
                Node currentNode = this.root;
                while(currentNode !=null)
                {
                    if (currentNode.left.value == value)
                    {
                        Node right = currentNode.left.right;
                        Node left = currentNode.left.left;
                        if (currentNode.left.right.left != null)
                            currentNode.left = currentNode.left.right.left;
                        else if (currentNode.left.right != null)
                            currentNode.left = currentNode.left.right;
                        else if (currentNode.left.left != null)
                            currentNode.left = currentNode.left.left;
                        else
                            currentNode.left = null;
                        if(currentNode.left !=null)
                        {
                            //currentNode.left.right = right;
                            currentNode.left.left = left;
                        }

                        break;
                    }
                    else if (currentNode.right.value ==value)
                    {
                        Node right = currentNode.right.right;
                        Node left = currentNode.right.left;

                        if (currentNode.right.right.left != null)
                            currentNode.right = currentNode.right.right.left;
                        else if (currentNode.right.right != null)
                            currentNode.right = currentNode.right.right;
                        else if (currentNode.left.left != null)
                            currentNode.right = currentNode.right.left;
                        else
                            currentNode.right = null;
                        if(currentNode.right !=null)
                        {
                            //currentNode.right.right = right;
                            currentNode.right.left = left;
                        }

                        break;
                    }
                    else if (value < currentNode.left.value)
                    {
                        //Right
                        currentNode = currentNode.left;
                    }
                    else if  (value >= currentNode.right.value)
                        currentNode = currentNode.right;
                }
           }
               

        }
        public Node Traverse(Node node)
        {
            Node tree = new Node(node.value);
            tree.left = node.left == null ? null : Traverse(node.left);
            tree.right = node.right == null ? null : Traverse(node.right);
            return tree;

        }
    }
}

//using System;
//using System.Web.Script.Serialization;

//class MainClass
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Hello World");
//        BinarySearchTree bst = new BinarySearchTree();
//        bst.insert(9);
//        //JsonConvert.SerializeObject(bst.Traverse(bst.root));
//        //string output = JsonConvert.SerializeObject(bst.Traverse//(bst.root));
//        //var json = new JavaScriptSerializer().Serialize(bst.Traverse//(bst.root));
//        Console.WriteLine(json);
//    }


//}

public class Node
{
    public Node left { get; set; }
    public Node right { get; set; }
    public int value { get; set; }
    public Node(int value)
    {
        this.left = null;
        this.right = null;
        this.value = value;
    }
}

