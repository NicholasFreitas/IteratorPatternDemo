using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPatternDemo
{
    class Program
    {
        /*
         The iterator lets you treat aggregates of varying objext similarly. In this demo, it's a simple demonstration of the pattern.
         Because there can be a lot of variable between how we traverse an aggregate we're just demonstrating the principle and main
         idea of the pattern. In the wild, there would be more complexity.
         NOTE: We've also created the aggregate mock in the constructor to really just focus on the pattern implementation rather
         than the specific object implementation.
          
           --------------------         -----------------
           |INodeAggregate    |         |INodeIterator()|
           --------------------         -----------------
           | GetNodeIterator()|         | GetCurrent()  |
           --------------------         | Nest()        |
                    ^                   | IsDone()      |
                    ^                   -----------------
                    |                           ^
                    |                           ^
                    |                           |
                    |                           |
           -------------------- Creates   -----------------
           | NodeAggregate    | -------> | NodeIterator()|
           --------------------          -----------------
           | GetNodeIterator()|          | GetCurrent()  |
           -------------------- <------- | Nest()        |
                                         | IsDone()      |
                                         -----------------
                         
             */

        static void Main(string[] args)
        {
            var nodeAgg = new NodeAggregate();
            var nodeIter = nodeAgg.GetNodeIterator();

            while (!nodeIter.IsDone())
            {
                nodeIter.GetCurrentNode().NodeBehavior();
                nodeIter.Next();
            }


        }
    }
}
