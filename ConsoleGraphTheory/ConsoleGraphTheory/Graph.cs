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
        private List<Node> nodes;
        public Graph()
        {
            amountGraph++;
            this.ID = amountGraph;
            this.Name = "Graph " + this.ID.ToString();
            this.Edges = new List<Edge>();
            this.nodes = new List<Node>();
        }
        public Graph(List<Node> nodes)
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
            this.nodes = new List<Node>();
            foreach(var edge in this.Edges)
            {
                this.nodes.Add(edge.FirstNode);
                this.nodes.Add(edge.SecondNode);
            }
            var newNode = this.nodes.GroupBy(x => x.Name).Select(x => x.First()).ToList();
            this.nodes = newNode;
        }
        public Graph(List<Node> nodes, List<Edge> edges)
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
            this.nodes = new List<Node>();
        }
        public void AddNode(Node nodeGraph)
        {
            this.nodes.Add(nodeGraph);
            this.nodes = this.nodes.Distinct().ToList();
            this.nodes.Sort();
        }
        public void AddNode(string name)
        {
            Node nodeGraph = new Node(name);
            this.nodes.Add(nodeGraph);
            this.nodes = this.nodes.Distinct().ToList();
            this.nodes.Sort();
        }
        public void AddNode(Node nodeGraph, List<Node> connectedNodes)
        {
            foreach (var connectedNode in connectedNodes)
                this.Edges.Add(new Edge(nodeGraph, connectedNode));
            this.nodes.Add(nodeGraph);
            this.nodes = this.nodes.Distinct().ToList();
            this.nodes.Sort();
        }
        public void AddNode(Node nodeGraph, List<string> connectedNodes)
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
            this.nodes.Add(nodeGraph);
            this.nodes = this.nodes.Distinct().ToList();
            this.nodes.Sort();
            this.Edges.Sort();
        }
        public void AddNode(string name, List<Node> connectedNodes)
        {
            Node nodeGraph = new Node(name);
            foreach (var node in connectedNodes)
                this.Edges.Add(new Edge(nodeGraph, node));
            this.nodes.Add(nodeGraph);
            this.nodes = this.nodes.Distinct().ToList();
            this.nodes.Sort();
            this.Edges.Sort();
        }
        public void AddNode(string name, List<string> connectedNodes)
        {
            Node nodeGraph = new Node(name);
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
            this.nodes.Add(nodeGraph);
            this.nodes = this.nodes.Distinct().ToList();
            this.Edges.Sort();
        }
        public void RemoveNode(Node nodeGraph)
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
        public void AddEdge(params Edge[] edges)
        {
            for (int i = 0; i < edges.Length; i++)
            {
                this.nodes.Add(edges[i].FirstNode);
                this.nodes.Add(edges[i].SecondNode);
                this.Edges.Add(edges[i]);
            }
            this.nodes = this.nodes.Distinct().ToList();
            this.nodes.Sort();
            this.Edges.Sort();
        }
        public void AddEdge(List<Edge> edges)
        {
            foreach(var edge in edges)
            {
                this.nodes.Add(edge.FirstNode);
                this.nodes.Add(edge.SecondNode);
                this.Edges.Add(edge);
            }
            this.nodes = this.nodes.Distinct().ToList();
            this.nodes.Sort();
            this.Edges.Sort();
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
