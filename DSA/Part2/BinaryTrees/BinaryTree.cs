namespace DSA.Part2.BinaryTrees
{

    public class BinaryTree
    {
        public Node root;

        public void Insert(int value)
        {
            if (root == null)
            {
                root = new Node(value);
                return;
            }

            Node node = FindNodeToInsert(value);

            if (node.val > value)
                node.leftChild = new Node(value);
            else
                node.rightChild = new Node(value);

        }

        public bool Find(int value)
        {
            return FindNode(root, value) != null;
        }

        private Node FindNodeToInsert(int value)
        {
            Node it = root;
            while (true)
            {
                if (it.val > value)
                {
                    if (it.leftChild == null)
                        return it;
                    else
                        it = it.leftChild;
                }
                else
                {
                    if (it.rightChild == null)
                        return it;
                    else
                        it = it.rightChild;
                }
            }
        }

        private Node FindNode(Node root, int val)
        {

            if (root == null)
                return null;

            if (root.val == val)
                return root;
            else if (root.val > val)
                return FindNode(root.leftChild, val);
            else
                return FindNode(root.rightChild, val);
        }

        public void InOrderTraversal()
        {
            InOrderTraversal(root);
        }

        public void PreOrderTraversal()
        {
            PreOrderTraversal(root);
        }

        public void PostOrderTraversal()
        {
            PostOrderTraversal(root);
        }

        private void InOrderTraversal(Node root)
        {

            if (root == null)
                return;

            if (root.leftChild != null)
                InOrderTraversal(root.leftChild);

            Console.Write("-->" + root.val);

            if (root.rightChild != null)
                InOrderTraversal(root.rightChild);
        }

        private void PreOrderTraversal(Node root)
        {

            if (root == null)
                return;

            Console.Write("-->" + root.val);

            if (root.leftChild != null)
                PreOrderTraversal(root.leftChild);

            if (root.rightChild != null)
                PreOrderTraversal(root.rightChild);
        }

        private void PostOrderTraversal(Node root)
        {

            if (root == null)
                return;

            if (root.leftChild != null)
                PostOrderTraversal(root.leftChild);

            if (root.rightChild != null)
                PostOrderTraversal(root.rightChild);

            Console.Write("-->" + root.val);
        }

        public int Height()
        {
            return Height(root);
        }

        //Using post order traversal to calculate height
        private int Height(Node root)
        {
            if (root == null)
                return -1;

            if (IsLeaf(root))
                return 0;

            return 1 + Math.Max(Height(root.leftChild), Height(root.rightChild));
        }


        public bool IsBalanced()
        {
            return IsBalanced(root);
        }

        //Naive approch. O(n^2) time complexity
        public bool IsBalanced(Node root)
        {
            if (root == null)
                return true;

            var leftBf = Height(root.leftChild);
            var rightBf = Height(root.rightChild);

            if (Math.Abs(leftBf - rightBf) <= 1 && IsBalanced(root.leftChild) && IsBalanced(root.rightChild))
                return true;
            return false;
        }

        public bool IsBalanced2()
        {
            return IsBalanced2(root) != -1;
        }

        //Better approch. O(n) time complexity
        public int IsBalanced2(Node root)
        {
            if (root == null)
                return 0;

            var leftHeight = IsBalanced2(root.leftChild);
            if (leftHeight == -1)
                return -1;

            var rightHeight = IsBalanced2(root.rightChild);
            if (rightHeight == -1)
                return -1;

            if (Math.Abs(leftHeight - rightHeight) <= 1)
                return Math.Max(leftHeight, rightHeight) + 1;
            return -1;
        }

        //A Binary tree is Perfect Binary Tree in which all internal nodes have two children and all leaves are at same level.
        public bool IsPerfect()
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            LevelOrderTraversal3(root, 0, dict);
            int expectedLevelSize = 1;
            for (int height = 0; height < dict.Count; height++)
            {
                if (dict[height] != expectedLevelSize)
                    return false;
                else
                    expectedLevelSize *= 2;
            }
            return true;
        }

        public void LevelOrderTraversal3(Node root, int height, Dictionary<int, int> dict)
        {
            if (root == null)
                return;

            if (!dict.ContainsKey(height))
                dict.Add(height, 1);
            else
                dict[height]++;

            LevelOrderTraversal3(root.leftChild, height + 1, dict);
            LevelOrderTraversal3(root.rightChild, height + 1, dict);
        }

        //A Perfect Binary Tree of height h (where height is number of nodes on path from root to leaf) has 2h – 1 nodes.
        public bool IsPerfect2()
        {
            return Size() == (Math.Pow(2, Height() + 1) - 1);
        }


        public int FindMin()
        {
            return FindMin(root);
        }

        private int FindMin(Node root)
        {
            if (root == null)
                return int.MaxValue;

            if (IsLeaf(root))
                return root.val;


            int leftMin = FindMin(root.leftChild);
            int rightMin = FindMin(root.rightChild);
            return Math.Min(root.val, Math.Min(leftMin, rightMin));
        }

        private bool IsLeaf(Node node)
        {
            return node.leftChild == null && node.rightChild == null;
        }

        public bool TreeEquals(Node treeRoot)
        {
            return TreeEquals(treeRoot, root);
        }

        private bool TreeEquals(Node tree1, Node tree2)
        {

            if (tree1 == null && tree2 != null || tree2 == null && tree1 != null)
                return false;

            if (tree1 == null && tree2 == null)
                return true;

            if (tree1 != null && tree2 != null)
                return tree1.val == tree2.val;

            return TreeEquals(tree1.leftChild, tree2.leftChild) && TreeEquals(tree1.rightChild, tree2.rightChild);
        }

        //Pre order
        private bool TreeEquals2(Node tree1, Node tree2)
        {

            if (tree1 == null && tree2 == null)
                return true;

            if (tree1 != null && tree2 != null)
                return tree1.val == tree2.val
                && TreeEquals(tree1.leftChild, tree2.leftChild)
                && TreeEquals(tree1.rightChild, tree2.rightChild);

            return false;
        }

        public bool IsBST()
        {
            return IsBST(root, int.MaxValue, int.MinValue);
        }

        private bool IsBST(Node root, int max, int min)
        {
            if (root == null)
                return true;

            var isBST = max > root.val && root.val > min;
            return isBST && IsBST(root.leftChild, root.val, min) && IsBST(root.rightChild, max, root.val);
        }

        //Write all the node with distance 3 from the root
        public List<int> NodesAtKDistance(int distance)
        {
            var list = new List<int>();
            NodesAtKDistance(root, distance, list);
            return list;
        }

        private static void NodesAtKDistance(Node root, int distance, List<int> result)
        {
            if (root == null)
                return;

            if (distance == 0)
            {
                result.Add(root.val);
                return;
            }

            NodesAtKDistance(root.leftChild, distance - 1, result);
            NodesAtKDistance(root.rightChild, distance - 1, result);
        }


        public void LevelOrderTraversal()
        {
            for (var i = 0; i <= Height(); i++)
            {
                foreach (var node in NodesAtKDistance(i))
                    Console.Write("->" + node);
                Console.WriteLine("");
            }
        }

        public void LevelOrderTraversal2()
        {
            var dict = new Dictionary<int, List<int>>();
            LevelOrderTraversal2(root, 0, dict);
            foreach (var height in dict)
            {
                foreach (var nodeVal in height.Value)
                    Console.Write("->" + nodeVal);
                Console.WriteLine();
            }
        }

        private void LevelOrderTraversal2(Node root, int height, Dictionary<int, List<int>> dict)
        {
            if (root == null)
                return;

            if (dict.ContainsKey(height))
                dict[height].Add(root.val);
            else
                dict.Add(height, new List<int>() { root.val });

            LevelOrderTraversal2(root.leftChild, height + 1, dict);
            LevelOrderTraversal2(root.rightChild, height + 1, dict);
        }

        public int Size()
        {
            return Size(root);
        }

        private int Size(Node root)
        {
            if (root == null)
                return 0;

            return 1 + Size(root.leftChild) + Size(root.leftChild);
        }

        public int CountLeaves()
        {
            return CountLeaves(root);
        }

        private int CountLeaves(Node root)
        {
            if (root == null)
                return 0;

            if (IsLeaf(root))
                return 1;

            return CountLeaves(root.leftChild) + CountLeaves(root.rightChild);
        }

        public bool Contains(int value)
        {
            return Contains(root, value);
        }

        private bool Contains(Node root, int value)
        {
            if (root == null)
                return false;

            if (root.val == value)
                return true;

            return Contains(root.leftChild, value) || Contains(root.rightChild, value);
        }

        public bool AreSibling(int value1, int value2)
        {
            return AreSibling(root, value1, value2);
        }

        private bool AreSibling(Node root, int value1, int value2)
        {
            if (root == null || root.leftChild == null || root.rightChild == null)
                return false;

            if (root.leftChild.val == value1 && root.rightChild.val == value2
            || root.leftChild.val == value2 && root.rightChild.val == value1)
                return true;

            return AreSibling(root.leftChild, value1, value2) || AreSibling(root.rightChild, value1, value2);
        }

        public List<int> GetAncestors(int value)
        {
            List<int> listOfAncestors = new();
            var foundNode = FindNode(root, value, listOfAncestors);
            if (!foundNode)
                throw new InvalidOperationException("Node not found");
            return listOfAncestors;
        }

        private static bool FindNode(Node root, int value, List<int> listOfAncestors)
        {
            if (root == null)
                return false;

            if (root.val == value)
                return true;

            bool found = FindNode(root.leftChild, value, listOfAncestors) || FindNode(root.rightChild, value, listOfAncestors);

            if (found)
                listOfAncestors.Add(root.val);

            return found;
        }
    }
}