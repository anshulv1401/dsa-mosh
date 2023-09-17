using System.Text;

namespace DSA.Part2.Graphs
{
    public class Graph
    {
        private class GNode
        {
            public string Label { get; }

            public GNode(string label)
            {
                Label = label;
            }

            public override string ToString()
            {
                return Label;
            }
        }

        readonly Dictionary<string, GNode> nodes = new();
        readonly Dictionary<GNode, HashSet<GNode>> adjacencyList = new();

        //AddNode(label);
        public void AddNode(string label)
        {
            var node = new GNode(label);
            nodes.TryAdd(label, node);
            adjacencyList.TryAdd(node, new HashSet<GNode>());
        }

        //RemoveNode(label);
        public void RemoveNode(string label)
        {
            if (!nodes.ContainsKey(label))
                return;

            //Detaching everynode from the nodetoberemoved
            foreach (var vertex in adjacencyList)
                vertex.Value.Remove(nodes[label]);

            adjacencyList.Remove(nodes[label]);
            nodes.Remove(label);
        }


        //AddEdge(from, to)
        public void AddEdge(string fromLabel, string toLabel)
        {
            if (!(nodes.ContainsKey(fromLabel) && nodes.ContainsKey(toLabel)))
                throw new InvalidOperationException("Not found");


            adjacencyList[nodes[fromLabel]].Add(nodes[toLabel]);

            //For undirected list we'll have to add inverse entry as well
            //adjacencyList[nodes[toLabel]].Add(nodes[fromLabel]);
        }

        //RemoveEdge(from, to)
        public void RemoveEdge(string fromLabel, string toLabel)
        {
            if (!nodes.ContainsKey(fromLabel) || !nodes.ContainsKey(toLabel))
                return;

            adjacencyList[nodes[fromLabel]].Remove(nodes[toLabel]);
        }

        //Print()
        //  A is connected to [B,C]
        //  B is connected to [A]
        public void Print()
        {
            Console.WriteLine("---------------------------");
            foreach (var vertex in adjacencyList)
                Console.WriteLine(vertex.Key + " is connected to [" + string.Join(",", vertex.Value) + "]");
        }
    }
}