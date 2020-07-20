using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGraphTheory
{
    struct NodeGraph: IComparable<NodeGraph>
    {
        public string Name { set; get; }
        public int ID { set; get; }
        public NodeGraph(string name, int ID)
        {
            this.Name = name;
            this.ID = ID;
        }
        public NodeGraph(int ID)
        {
            this.Name = ID.ToString();
            this.ID = ID;
        }
        public int CompareTo(NodeGraph node)
        {
            return this.ID.CompareTo(node.ID);
        }
    }
}
