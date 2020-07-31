using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGraphTheory
{
    struct Node: IComparable<Node>
    {
        public string Name { set; get; }
        public Node(string name)
        {
            this.Name = name;
        }
        public int CompareTo(Node node)
        {
            return this.Name.CompareTo(node.Name);
        }
    }
}
