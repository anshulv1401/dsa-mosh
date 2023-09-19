using System.Text;

namespace DSA.Part2.Graphs
{
    public class WeightedGraph
    {
        private class Node
        {
            private readonly string label;
            private readonly List<Edge> edges = new();

            public Node(string label)
            {
                this.label = label;
            }

            public void AddEdge(Node to, int weight)
            {
                edges.Add(new Edge(this, to, weight));
            }

            public List<Edge> GetEdges()
            {
                return edges;
            }

            public override string ToString()
            {
                return label;
            }
        }

        private class Edge
        {
            private readonly Node from;
            private readonly Node to;
            private readonly int weight;

            public Edge(Node from, Node to, int weight)
            {
                this.from = from;
                this.to = to;
                this.weight = weight;
            }

            public override string ToString()
            {
                return from + "-->" + weight + "-->" + to;
            }
        }

        readonly Dictionary<string, Node> nodes = new();

        //AddNode(label);
        public void AddNode(string label)
        {
            nodes.TryAdd(label, new Node(label));
        }

        //AddEdge(from, to, weight)
        public void AddEdge(string fromLabel, string toLabel, int weight)
        {
            if (!(nodes.ContainsKey(fromLabel) && nodes.ContainsKey(toLabel)))
                throw new InvalidOperationException("Not found");


            nodes[toLabel].AddEdge(nodes[fromLabel], weight);
            nodes[fromLabel].AddEdge(nodes[toLabel], weight);
        }


        //Print()
        //  A is connected to [B,C]
        //  B is connected to [A]
        public void Print()
        {
            Console.WriteLine("---------------------------");
            foreach (var node in nodes)
            {
                Console.WriteLine(node.Key + " is connected to [" + string.Join(",", node.Value.GetEdges()) + "]");
            }
        }
    }
}