using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGraphTheory
{
    partial class Graph : IGraph
    {
        public string Name { set; get; }
        private int ID;
        private static int amountGraph = 0;
        public List<Edge> Edges { set; get; }
        private List<NodeGraph> nodes;
        public Graph(List<NodeGraph> nodes)
        {
            amountGraph++;
            this.ID = amountGraph;
            this.Name = "Graph " + this.ID.ToString();
            this.Edges = new List<Edge>();
            this.nodes = nodes;
        }
        public Graph(List<Edge> edges)
        {
            amountGraph++;
            this.ID = amountGraph;
            this.Name = "Graph " + this.ID.ToString();
            this.Edges = edges;
            this.nodes = new List<NodeGraph>();
            foreach(var edge in this.Edges)
            {
                this.nodes.Add(edge.FirstNode);
                this.nodes.Add(edge.SecondNode);
            }
            var newNode = this.nodes.GroupBy(x => x.ID).Select(x => x.First()).ToList();
            this.nodes = newNode;
        }
        public Graph(List<NodeGraph> nodes, List<Edge> edges)
        {
            amountGraph++;
            this.ID = amountGraph;
            this.Name = "Graph " + this.ID.ToString();
            this.Edges = edges;
            this.nodes = nodes;
        }
        public Graph(string name)
        {
            amountGraph++;
            this.ID = amountGraph;
            this.Name = name;
            this.Edges = new List<Edge>();
            this.nodes = new List<NodeGraph>();
        }
        public void AddNode(NodeGraph nodeGraph)
        {
            this.nodes.Add(nodeGraph);
        }
        public void AddNode(int ID)
        {
            NodeGraph nodeGraph = new NodeGraph(ID);
            this.nodes.Add(nodeGraph);
        }
        public void AddNode(string name, int ID)
        {
            NodeGraph nodeGraph = new NodeGraph(name, ID);
            this.nodes.Add(nodeGraph);
        }
        public void AddNode(NodeGraph nodeGraph, List<NodeGraph> connectedNodes)
        {
            foreach (var connectedNode in connectedNodes)
                this.Edges.Add(new Edge(nodeGraph, connectedNode));
        }
        public void AddNode(NodeGraph nodeGraph, List<int> connectedNodes)
        {
            foreach (var node in nodes)
            {
                for (int i = 0; i < connectedNodes.Count; i++)
                {
                    if (node.ID == connectedNodes[i])
                    {
                        this.Edges.Add(new Edge(nodeGraph, node));
                        connectedNodes.RemoveAt(i);
                        break;
                    }
                }
            }
        }
        public void AddNode(NodeGraph nodeGraph, List<string> connectedNodes)
        {
            foreach (var node in nodes)
            {
                for (int i = 0; i < connectedNodes.Count; i++)
                {
                    if (node.Name == connectedNodes[i])
                    {
                        this.Edges.Add(new Edge(nodeGraph, node));
                        connectedNodes.RemoveAt(i);
                        break;
                    }
                }
            }
        }
        public void AddNode(string name, int ID, List<NodeGraph> connectedNodes)
        {
            NodeGraph nodeGraph = new NodeGraph(name, ID);
            foreach (var node in connectedNodes)
                this.Edges.Add(new Edge(nodeGraph, node));
        }
        public void AddNode(string name, int ID, List<int> connectedNodes)
        {
            NodeGraph nodeGraph = new NodeGraph(name, ID);
            foreach (var node in nodes)
            {
                for (int i = 0; i < connectedNodes.Count; i++)
                {
                    if (node.ID == connectedNodes[i])
                    {
                        this.Edges.Add(new Edge(nodeGraph, node));
                        connectedNodes.RemoveAt(i);
                        break;
                    }
                }
            }
        }
        public void AddNode(string name, int ID, List<string> connectedNodes)
        {
            NodeGraph nodeGraph = new NodeGraph(name, ID);
            foreach (var node in nodes)
            {
                for (int i = 0; i < connectedNodes.Count; i++)
                {
                    if (node.Name == connectedNodes[i])
                    {
                        this.Edges.Add(new Edge(nodeGraph, node));
                        connectedNodes.RemoveAt(i);
                        break;
                    }
                }
            }
        }
        public void RemoveNode(NodeGraph nodeGraph)
        {
            foreach (var node in nodes)
            {
                if (Equals(node, nodeGraph))
                {
                    nodes.Remove(node);
                    foreach (var edge in Edges)
                    {
                        if (Equals(node, edge.FirstNode) || Equals(node, edge.SecondNode))
                        {
                            this.Edges.Remove(edge);
                        }
                    }
                    break;
                }
            }
        }
        public void RemoveNode(string name)
        {
            foreach (var node in nodes)
            {
                if (Equals(node.Name, name))
                {
                    nodes.Remove(node);
                    foreach (var edge in Edges)
                    {
                        if (Equals(node, edge.FirstNode) || Equals(node, edge.SecondNode))
                        {
                            this.Edges.Remove(edge);
                        }
                    }
                    break;
                }
            }
        }
        public void RemoveNode(int ID)
        {
            foreach (var node in nodes)
            {
                if (Equals(node.ID, ID))
                {
                    nodes.Remove(node);
                    foreach (var edge in Edges)
                    {
                        if (Equals(node, edge.FirstNode) || Equals(node, edge.SecondNode))
                        {
                            this.Edges.Remove(edge);
                        }
                    }
                    break;
                }
            }
        }
        public void AddEdge(params Edge[] edges)
        {
            for (int i = 0; i < edges.Length; i++)
                this.Edges.Add(edges[i]);
        }
        public void AddEdge(List<Edge> edges)
        {
            this.Edges.AddRange(edges);
        }
        public void RemoveEdge(params Edge[] edges)
        {
            for (int i = 0; i < edges.Length; i++)
                this.Edges.Remove(edges[i]);
        }
        public void RemoveEdge(List<Edge> edges)
        {
            foreach (var edge in edges)
                this.Edges.Remove(edge);
        }
    }
}
