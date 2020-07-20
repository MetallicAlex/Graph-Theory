using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGraphTheory
{
    class Edge: IComparable<Edge>
    {
        public NodeGraph FirstNode { private set; get; }
        public NodeGraph SecondNode { private set; get; }
        public Edge(NodeGraph firstNode, NodeGraph secondNode)
        {
            this.FirstNode = firstNode;
            this.SecondNode = secondNode;
        }
        public int CompareTo(Edge edge)
        {
            return this.FirstNode.ID.CompareTo(edge.FirstNode.ID);
        }
    }
}