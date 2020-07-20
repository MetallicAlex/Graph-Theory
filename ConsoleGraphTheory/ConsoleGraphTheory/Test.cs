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
            Graph graph = new Graph("Graph1");
            graph.AddEdge(new Edge(new NodeGraph(1), new NodeGraph(4)),
                          new Edge(new NodeGraph(2), new NodeGraph(3)),
                          new Edge(new NodeGraph(1), new NodeGraph(3)),
                          new Edge(new NodeGraph(4), new NodeGraph(2))
                          );
            graph.ShowNode();
            graph.RemoveEdge(new Edge(new NodeGraph(1), new NodeGraph(3)));
            graph.ShowNode();
        }
    }
}
