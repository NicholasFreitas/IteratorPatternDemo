using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPatternDemo
{
    interface INodeIterator
    {
        bool IsDone();
        void Next();
        INode GetCurrentNode();
    }
}
