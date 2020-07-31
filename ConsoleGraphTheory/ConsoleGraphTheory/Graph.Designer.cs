using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGraphTheory
{
    partial class Graph: IGraph
    {
        public void ShowNode()
        {
            ConsoleTable.Table table = new ConsoleTable.Table();
            table.SetHeaders("Node", "Connected Nodes");
            List<List<Node>> connectedNodes = new List<List<Node>>();
            foreach (var node in this.nodes)
            {
                connectedNodes.Add(new List<Node>());
                foreach (var edge in this.Edges)
                {
                    if (node.Name == edge.FirstNode.Name)
                    {
                        connectedNodes[connectedNodes.Count - 1].Add(edge.SecondNode);
                    }
                    else if (node.Name == edge.SecondNode.Name)
                    {
                        connectedNodes[connectedNodes.Count - 1].Add(edge.FirstNode);
                    }
                }
            }
            for (int i = 0; i < this.nodes.Count; i++)
            {
                connectedNodes[i].Sort();
                table.AddRow(nodes[i].Name, String.Join(", ", connectedNodes[i].Select(x => x.Name).ToArray()));
            }
            Console.WriteLine(table.ToString());
        }
        public void ShowDegs()
        {

        }
        public void ShowProperty()
        {

        }
    }
}
