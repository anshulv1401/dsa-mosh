using System.Collections;
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
            public readonly Node from;
            public readonly Node to;
            public readonly int weight;

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

        //Dijkstra's Algo
        public List<string> GetShortestDistanceIterative(string from, string to)
        {
            if (!(nodes.ContainsKey(from) && nodes.ContainsKey(to)))
                throw new InvalidOperationException();

            var fromNode = nodes[from];
            var toNode = nodes[to];
            var priorityQueue = new PriorityQueue<Node, int>();
            var visited = new HashSet<Node>();

            var distances = new Dictionary<Node, int>();
            var previousNodes = new Dictionary<Node, Node>();

            foreach (var node in nodes.Values)
            {
                distances[node] = int.MaxValue;
            }

            previousNodes[fromNode] = null;
            distances[fromNode] = 0;
            priorityQueue.Enqueue(fromNode, 0);

            while (priorityQueue.Count > 0)
            {
                var current = priorityQueue.Dequeue();
                visited.Add(current);

                foreach (var edge in current.GetEdges())
                {
                    var neighbor = edge.to;
                    if (visited.Contains(neighbor))
                        continue;

                    var newDistance = edge.weight + distances[current];
                    if (distances[neighbor] > newDistance)
                    {
                        distances[neighbor] = newDistance;
                        previousNodes[neighbor] = current;
                        priorityQueue.Enqueue(neighbor, newDistance);
                    }
                }
            }

            return BuildPath(previousNodes, toNode);
        }

        private static List<string> BuildPath(Dictionary<Node, Node> previousNodes, Node toNode)
        {
            var stack = new Stack<string>();

            var previousNode = toNode;
            while (previousNode != null)
            {
                stack.Push(previousNode.ToString());
                previousNode = previousNodes[previousNode];
            }

            return stack.ToList();

        }

        //Dijkstra's Algo
        public int GetShortestDistanceRecursive(string from, string to)
        {
            if (!(nodes.ContainsKey(from) && nodes.ContainsKey(to)))
                return int.MaxValue;

            var fromNode = nodes[from];
            var priorityQueue = new PriorityQueue<Node, int>();
            var distances = new Dictionary<Node, int>();
            var previousNodes = new Dictionary<Node, Node>();
            var visited = new HashSet<Node>();

            foreach (var node in nodes.Values)
            {
                distances.Add(node, int.MaxValue);
            }

            previousNodes[fromNode] = null;
            distances[fromNode] = 0;
            GetShortestDistanceRecursive(fromNode, visited, priorityQueue, distances, previousNodes);

            var previousNode = nodes[to];
            while (previousNode != null)
            {
                Console.Write(previousNode + "-->" + distances[previousNode] + "-->");
                previousNode = previousNodes[previousNode];
            }
            Console.WriteLine("");

            return distances[nodes[to]];
        }


        private void GetShortestDistanceRecursive(Node current, HashSet<Node> visited, PriorityQueue<Node, int> priorityQueue, Dictionary<Node, int> distances, Dictionary<Node, Node> previousNodes)
        {
            if (visited.Contains(current))
                return;

            foreach (var edge in current.GetEdges())
            {
                var neighbor = edge.to;

                if (visited.Contains(neighbor))
                    continue;

                var newDistance = edge.weight + distances[current];
                if (distances[neighbor] > newDistance)
                {
                    distances[neighbor] = newDistance;
                    previousNodes[neighbor] = current;
                    priorityQueue.Enqueue(neighbor, newDistance);
                }
            }

            visited.Add(current);

            if (priorityQueue.Count <= 0)
            {
                return;
            }
            var nearestNeighbor = priorityQueue.Dequeue();

            GetShortestDistanceRecursive(nearestNeighbor, visited, priorityQueue, distances, previousNodes);
        }

        public bool HasCycle()
        {
            var visited = new HashSet<Node>();

            foreach (var node in nodes.Values)
            {
                if (visited.Contains(node))
                    continue;

                if (HasCycle(node, null, visited))
                    return true;
            }

            return false;
        }


        private bool HasCycle(Node node, Node parent, HashSet<Node> visited)
        {
            visited.Add(node);

            foreach (var edges in node.GetEdges())
            {
                if (edges.to == parent)
                    continue;

                if (visited.Contains(edges.to))
                    return true;

                if (HasCycle(edges.to, node, visited))
                    return true;
            }

            return false;
        }

        //Prims Algorithm
        public WeightedGraph GetMinSpanningTree()
        {
            PriorityQueue<Edge, int> edges = new();
            WeightedGraph tree = new();
            HashSet<Node> visited = new();

            if (nodes.Count <= 0)
                return tree;

            var iterator = nodes.Values.GetEnumerator();
            iterator.MoveNext();
            visited.Add(iterator.Current);
            tree.AddNode(iterator.Current.ToString());

            foreach (var edge in iterator.Current.GetEdges())
                edges.Enqueue(edge, edge.weight);

            while (edges.Count > 0)
            {
                var currentEdge = edges.Dequeue();
                var current = currentEdge.from;
                var nextNode = currentEdge.to;

                if (visited.Contains(nextNode))
                    continue;

                visited.Add(nextNode);
                tree.AddNode(nextNode.ToString());
                tree.AddEdge(current.ToString(), nextNode.ToString(), currentEdge.weight);

                foreach (var edge in nextNode.GetEdges())
                    if (!visited.Contains(edge.to))
                        edges.Enqueue(edge, edge.weight);
            }

            return tree;
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