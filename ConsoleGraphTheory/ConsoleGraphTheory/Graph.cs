using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGraphTheory
{
    partial class Graph: IComparer<NodeGraph>, IGraph
    {
        public string Name { set; get; }
        private int ID;
        private static int amountGraph = 0;
        public SortedDictionary<NodeGraph, List<NodeGraph>> Edges { set; get; }
        private List<NodeGraph> degs;
        public Graph()
        {
            amountGraph++;
            this.ID = amountGraph;
            this.Name = "Graph " + this.ID.ToString();
            this.Edges = new SortedDictionary<NodeGraph, List<NodeGraph>>();
            this.degs = new List<NodeGraph>();
        }
        public Graph(string name)
        {
            amountGraph++;
            this.ID = amountGraph;
            this.Name = name;
            this.Edges = new SortedDictionary<NodeGraph, List<NodeGraph>>();
            this.degs = new List<NodeGraph>();
        }
        public int Compare(NodeGraph nodeGraph1, NodeGraph nodeGraph2)
        {
            if(nodeGraph1.ID > nodeGraph2.ID)
                return 1;
            else if (nodeGraph1.ID < nodeGraph2.ID)
                return -1;
            else
                return 0;
        }
        public void AddNode(NodeGraph nodeGraph, List<NodeGraph> edges)
        {
            this.Edges.Add(nodeGraph, edges);
        }
        public void AddNode(NodeGraph nodeGraph, List<int> edges)
        {
            List<NodeGraph> listEdges = new List<NodeGraph>();
            foreach (var node in Edges)
            {
                for (int i = 0; i < edges.Count; i++)
                {
                    if (node.Key.ID == edges[i])
                    {
                        listEdges.Add(node.Key);
                        edges.RemoveAt(i);
                        break;
                    }
                }
            }
            this.Edges.Add(nodeGraph, listEdges);
        }
        public void AddNode(NodeGraph nodeGraph, List<string> edges)
        {
            List<NodeGraph> listEdges = new List<NodeGraph>();
            foreach (var node in Edges)
            {
                for (int i = 0; i < edges.Count; i++)
                {
                    if (node.Key.Name == edges[i])
                    {
                        listEdges.Add(node.Key);
                        edges.RemoveAt(i);
                        break;
                    }
                }
            }
            this.Edges.Add(nodeGraph, listEdges);
        }
        public void AddNode(string name, int ID, List<NodeGraph> edges)
        {
            NodeGraph nodeGraph = new NodeGraph(name, ID);
            this.Edges.Add(nodeGraph, edges);
        }
        public void AddNode(string name, int ID, List<int> edges)
        {
            NodeGraph nodeGraph = new NodeGraph(name, ID);
            List<NodeGraph> listEdges = new List<NodeGraph>();
            foreach (var node in Edges)
            {
                for (int i = 0; i < edges.Count; i++)
                {
                    if (node.Key.ID == edges[i])
                    {
                        listEdges.Add(node.Key);
                        edges.RemoveAt(i);
                        break;
                    }
                }
            }
            this.Edges.Add(nodeGraph, listEdges);
        }
        public void AddNode(string name, int ID, List<string> edges)
        {
            NodeGraph nodeGraph = new NodeGraph(name, ID);
            List<NodeGraph> listEdges = new List<NodeGraph>();
            foreach (var node in Edges)
            {
                for (int i = 0; i < edges.Count; i++)
                {
                    if (node.Key.Name == edges[i])
                    {
                        listEdges.Add(node.Key);
                        edges.RemoveAt(i);
                        break;
                    }
                }
            }
            this.Edges.Add(nodeGraph, listEdges);
        }
        public void RemoveNode(NodeGraph nodeGraph)
        {
            foreach (var node in Edges)
            {
                if (Equals(node.Key, nodeGraph))
                {
                    Edges.Remove(node.Key);
                    break;
                }
            }
        }
        public void RemoveNode(string name)
        {
            foreach (var node in Edges)
            {
                if (Equals(node.Key.Name, name))
                {
                    Edges.Remove(node.Key);
                    break;
                }
            }
        }
        public void RemoveNode(int ID)
        {
            foreach (var node in Edges)
            {
                if (Equals(node.Key.ID, ID))
                {
                    Edges.Remove(node.Key);
                    break;
                }
            }
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
            return -1;
        }
        public int Deg(string name)
        {
            foreach (var edge in Edges)
            {
                if (edge.Key.Name == name)
                    return edge.Value.Count;
            }
            return -1;
        }
    }
}
