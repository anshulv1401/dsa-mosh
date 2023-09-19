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


        // Enqueue(root)
        // while (stack is not empty)
        //  current = Dequeue()
        //  visit(current)
        //  Enqueue each unvisited neightbour onto the stack
        public List<string> TraverseBreathFirstIterative(string root)
        {
            var resultList = new List<string>();

            if (!nodes.ContainsKey(root))
                return resultList;

            var visited = new HashSet<GNode>();

            Queue<GNode> stack = new();
            stack.Enqueue(nodes[root]);
            while (stack.Count > 0)
            {
                var current = stack.Dequeue();
                if (visited.Contains(current))
                    continue;

                visited.Add(current);
                resultList.Add(current.Label);
                foreach (var vertex in adjacencyList[current])
                    if (visited.Contains(current))
                        stack.Enqueue(vertex);
            }
            return resultList;
        }

        //similar to TraverseDepthFirstRecursive
        public List<string> TopologicalSort()
        {
            var visited = new HashSet<GNode>();
            var stack = new Stack<GNode>();
            foreach (var node in nodes)
                TopologicalSort(node.Value, visited, stack);

            var resultList = new List<string>();
            while (stack.Count > 0)
                resultList.Add(stack.Pop().Label);
            return resultList;
        }

        private void TopologicalSort(GNode root, HashSet<GNode> visited, Stack<GNode> stack)
        {
            if (visited.Contains(root))
                return;

            visited.Add(root);
            foreach (var node in adjacencyList[root])
                TopologicalSort(node, visited, stack);

            stack.Push(root);
        }


        public bool HasCycle()
        {
            var allNodes = new HashSet<GNode>();
            foreach (var node in nodes)
                allNodes.Add(node.Value);


            var visited = new HashSet<GNode>();
            var visiting = new HashSet<GNode>();
            var neighborTracker = new Dictionary<GNode, GNode>();

            while (allNodes.Count > 0)
            {
                // var current = allNodes.First();
                var iterator = allNodes.GetEnumerator();
                iterator.MoveNext();
                neighborTracker.Add(iterator.Current, null);

                if (HasCycle(iterator.Current, allNodes, visited, visiting, neighborTracker))
                {
                    foreach (var node in neighborTracker)
                        Console.Write(" " + node);
                    return true;
                }
            }


            return false;
        }

        private bool HasCycle(GNode node, HashSet<GNode> allNodes, HashSet<GNode> visited, HashSet<GNode> visiting, Dictionary<GNode, GNode> neighborTracker)
        {
            allNodes.Remove(node);
            visiting.Add(node);

            foreach (var neighbor in adjacencyList[node])
            {
                if (visited.Contains(node))
                    continue;

                if (visiting.Contains(node))
                    return true;

                if (neighborTracker.ContainsKey(node))
                    neighborTracker[node] = neighbor;
                else
                    neighborTracker.Add(node, neighbor);

                if (HasCycle(neighbor, allNodes, visited, visiting, neighborTracker))
                    return true;
            }

            visiting.Remove(node);
            visited.Add(node);
            return false;
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