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

        readonly Dictionary<GNode, List<GNode>> adjacencyList = new();

        //AddNode(label);
        public void AddNode(string label)
        {
            var node = new GNode(label);
            nodes.TryAdd(label, node);
            adjacencyList.TryAdd(node, new List<GNode>());
        }

        //RemoveNode(label);
        public void RemoveNode(string label)
        {
            if (!nodes.ContainsKey(label))
                return;

            //Detaching everynode from the nodetoberemoved
            foreach (var vertex in adjacencyList)
                vertex.Value.RemoveAll(node => node == nodes[label]);

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

            adjacencyList[nodes[fromLabel]].RemoveAll(node => node == nodes[toLabel]);
        }

        public List<string> TraverseDepthFirstRecursive(string root)
        {
            var resultList = new List<string>();

            if (!nodes.ContainsKey(root))
                return resultList;

            var resultHash = new HashSet<GNode>();
            TraverseDepthFirstResursive(nodes[root], resultHash);

            foreach (var result in resultHash)
                resultList.Add(result.Label);
            return resultList;
        }

        private void TraverseDepthFirstResursive(GNode gNode, HashSet<GNode> visited)
        {
            if (visited.Contains(gNode))
                return;

            visited.Add(gNode);

            foreach (var vertex in adjacencyList[gNode])
                TraverseDepthFirstResursive(vertex, visited);
        }


        // Push(root)
        // while (stack is not empty)
        //  current = pop()
        //  visit(current)
        //  push each unvisited neightbour onto the stack
        public List<string> TraverseDepthFirstIterative(string root)
        {
            var resultList = new List<string>();

            if (!nodes.ContainsKey(root))
                return resultList;

            var visited = new HashSet<GNode>();

            Stack<GNode> stack = new();
            stack.Push(nodes[root]);
            while (stack.Count > 0)
            {
                var current = stack.Pop();
                if (visited.Contains(current))
                    continue;

                visited.Add(current);
                resultList.Add(current.Label);
                foreach (var vertex in adjacencyList[current])
                    if (visited.Contains(current))
                        stack.Push(vertex);
            }
            return resultList;
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