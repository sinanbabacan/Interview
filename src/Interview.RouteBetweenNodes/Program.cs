using System;
using System.Linq;
using QuickGraph;

namespace Interview.RouteBetweenNodes
{
    public class Node
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public Node(string name, int value)
        {
            Name = name;
            Value = value;
        }
    }

    public class Edge<Node> : IEdge<Node>
    {

        public Edge(Node source, Node target)
        {
            Source = source;
            Target = target;
        }

        public Node Source { get; }

        public Node Target { get; }
    }


    class Program
    {


        static void Main(string[] args)
        {
            AdjacencyGraph<Node, Edge<Node>> adjacencyGraph1 = new AdjacencyGraph<Node, Edge<Node>>();

            AdjacencyGraph<int, IEdge<int>> adjacencyGraph2 = new AdjacencyGraph<int, IEdge<int>>();

            Node n1 = new Node("A", 1);
            Node n2 = new Node("B", 2);
            Node n3 = new Node("C", 3);
            Node n4 = new Node("D", 4);

            var edge = new Edge<Node>(n1, n2);
            var edge2 = new Edge<Node>(n3, n4);

            adjacencyGraph1.AddVertex(n1);
            adjacencyGraph1.AddVertex(n2);

            adjacencyGraph1.AddEdge(edge);
            adjacencyGraph1.AddEdge(edge2);

            Edge<Node> edge1 = adjacencyGraph1.Edges.Last();

            Console.WriteLine("Hello World!");
        }
    }
}
