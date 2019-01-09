using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPatternDemo
{
    class NodeAggregate : INodeAggregate
    {
        public INodeIterator GetNodeIterator()
        {
            return new NodeIterator();
        }
    }
}
