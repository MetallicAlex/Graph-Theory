using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGraphTheory
{
    class Edge: IComparable<Edge>
    {
        public Node FirstNode { private set; get; }
        public Node SecondNode { private set; get; }
        public Edge(Node firstNode, Node secondNode)
        {
            this.FirstNode = firstNode;
            this.SecondNode = secondNode;
        }
        public Edge(string firstNode, string secondNode)
        {
            this.FirstNode = new Node(firstNode);
            this.SecondNode = new Node(secondNode);
        }
        public int CompareTo(Edge edge)
        {
            return this.FirstNode.Name.CompareTo(edge.FirstNode.Name);
        }
    }
}