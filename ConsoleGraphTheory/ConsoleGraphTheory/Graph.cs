using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGraphTheory
{
    class Graph
    {
        public Dictionary<NodeGraph, List<NodeGraph>> Edges { set; get; }
        private List<NodeGraph> degs;
        public void AddNode(NodeGraph nodeGraph, List<NodeGraph> edges)
        {

        }
        public void AddNode(NodeGraph nodeGraph, List<int> edges)
        {

        }
        public void AddNode(NodeGraph nodeGraph, List<string> edges)
        {

        }
        public void AddNode(string name, int ID, List<NodeGraph> edges)
        {

        }
        public void AddNode(string name, int ID, List<int> edges)
        {

        }
        public void AddNode(string name, int ID, List<string> edges)
        {

        }
        public void RemoveNode(NodeGraph nodeGraph)
        {

        }
        public void RemoveNode(string name)
        {

        }
        public void RemoveNode(int ID)
        {

        }
        public int Deg(NodeGraph nodeGraph)
        {
            return Edges[nodeGraph].Count;
        }
        public int Deg(int ID)
        {
            foreach(var edge in Edges)
            {
                if(edge.Key.ID == ID)
                    return edge.Value.Count;
            }
            return 0;
        }
        public int Deg(string name)
        {
            foreach (var edge in Edges)
            {
                if (edge.Key.Name == name)
                    return edge.Value.Count;
            }
            return 0;
        }
    }
}
