using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGraphTheory
{
    struct NodeGraph
    {
        public string Name { set; get; }
        public int ID { set; get; }
        public NodeGraph(string name, int ID)
        {
            this.Name = name;
            this.ID = ID;
        }
    }
}
