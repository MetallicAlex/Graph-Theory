using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGraphTheory
{
    class Test
    {
        public static void AddNodes()
        {
            List<Node> nodes = new List<Node>();
            nodes.Add(new Node("a"));
            nodes.Add(new Node("b"));
            Graph graph = new Graph();
            graph.AddNode("d");
            graph.AddNode(nodes[0]);
            graph.AddNode("c", nodes);
            graph.AddEdge(new Edge("a", "b"), new Edge("d", "a"));
            graph.ShowNode();
        }
    }
}
