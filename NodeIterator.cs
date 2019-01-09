using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPatternDemo
{
    class NodeIterator : INodeIterator
    {
        private Node[] NodeArray = new Node[10];
               
        long _currentLoctionInNodeListing = 0;
        
        public NodeIterator()
        {
            //Mocking aggregate to demonstrate pattern
            for (int i = 0; i < NodeArray.Length; i++)
            {
                NodeArray[i] = new Node(i);
            }
            
        }

        public INode GetCurrentNode()
        {
            return NodeArray[_currentLoctionInNodeListing];
        }

        public bool IsDone()
        {
            if (_currentLoctionInNodeListing == NodeArray.Length)
                return true;

            return false;
        }

        public void Next()
        {
            _currentLoctionInNodeListing++;
        }
    }
}
