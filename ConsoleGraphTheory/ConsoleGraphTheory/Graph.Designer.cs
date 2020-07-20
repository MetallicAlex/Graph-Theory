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
            this.Edges.Sort();
            foreach(var edge in this.Edges)
            {
                table.AddRow(edge.FirstNode.Name, edge.SecondNode.Name);
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
