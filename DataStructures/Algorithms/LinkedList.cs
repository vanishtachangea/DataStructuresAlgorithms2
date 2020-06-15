using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    
    // Definition for a Node.
    public class Node {
        public int val;
        public Node next;
        public Node random;

        public Node(int _val) {
            val = _val;
            next = null;
            random = null;
        }
    }
    

    public class LinkedListClass
    {
        Dictionary<Node, Node> visited = new Dictionary<Node, Node>();
        public Node CopyRandomList(Node head)
        {

            if (head == null)
                return null;
            if (visited.ContainsKey(head))
            {
                return visited[head];
            }



            Node newCurrent = new Node(head.val);
            visited.Add(head, newCurrent);

            newCurrent.next = CopyRandomList(head.next);
            newCurrent.random = CopyRandomList(head.random);

            return newCurrent;

        }

    }
}
