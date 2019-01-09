using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPatternDemo
{
    class Node : INode
    {
        int Index;

        public Node(int index)
        {
            Index = index;
        }

        public void NodeBehavior()
        {
            Console.WriteLine("Node : " + Index.ToString());
        }
    }
}
