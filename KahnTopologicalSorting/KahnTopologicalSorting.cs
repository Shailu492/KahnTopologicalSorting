using System;
using System.Collections.Generic;

namespace KahnTopologicalSorting
{
    public class GraphUtils
    {
        public static IList<Node> GetSorted(ISet<Node> graph)
        {
            List<Node> sortedNodes = new List<Node>();
            List<Node> startingNodes = new List<Node>();


            while (startingNodes.Count > 0)
            {

            }

            return null;

        }

        private static ISet<Node> GetStartingNodes(ISet<Node> graph)
        {
            HashSet<Node> candidate = new HashSet<Node>(graph);

            foreach (Node node in graph)
            {
                foreach (Node pointedNode in node.Edges)
                {
                    candidate.Remove(pointedNode);
                }
            }

            return candidate;
        }
    }

    public class Graph
    {
        private List<Node> nodes;

        public Graph()
        {
            nodes = new List<Node>();
        }
    }

    public class Node
    {
        private object data;
        private List<Node> edges;

        public Node()
        {
            this.data = null;
            this.edges = new List<Node>();
        }

        public Node(object data)
        {
            this.data = data;
            this.edges = new List<Node>();
        }

        public Node(IEnumerable<Node> edges)
        {
            this.data = null;
            this.edges = new List<Node>(edges);
        }

        public void AddEdge(Node node)
        {
            edges.Add(node);
        }

        public void RemoveEdge(Node node)
        {
            edges.Remove(node);
        }

        public object Data 
        { 
            get => data; 
            set => data = value; 
        }

        public List<Node> Edges
        {
            get => edges;
        }
    }
}
