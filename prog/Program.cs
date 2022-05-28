using System;
using System.Collections.Generic;
using System.Linq;

namespace prog
{
    class Node
    {
        List<Node> children = new List<Node>();

        Node child;
        Node parent;

        public void addNode(Node node)
        {
            children.Add(node);
            node.parent = this;
        }

        public void remove()
        {
            for (int i = 0; i < children.Count; i++)
            {
                Node temp = children[i];
                this.parent.addNode(temp);
            }
            children.Clear();
        }

        public int count()
        {
            int sum = 1;
            foreach (Node n in children)
            {
                if (n.count() > 1)
                {
                    sum += n.count();
                }
            }


            return sum + children.Count();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            

            

            
            
        }
    }
}
