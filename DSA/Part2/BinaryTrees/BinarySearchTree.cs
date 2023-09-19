namespace DSA.Part2.BinaryTrees
{

    public class BinarySearchTree
    {
        private class Node
        {
            public Node(int val)
            {
                this.val = val;
            }

            public int val;
            public Node leftChild;
            public Node rightChild;

            public override string ToString()
            {
                return "Node:" + val;
            }
        }

        private Node root;

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

        //O(log n)
        public int FindMin()
        {
            if (root == null)
                throw new InvalidOperationException();

            var current = root;

            while (current.leftChild != null)
            {
                current = current.leftChild;
            }

            return current.val;
        }

        private bool IsLeaf(Node node)
        {
            return node.leftChild == null && node.rightChild == null;
        }

        public int FindMax()
        {
            if (root == null)
                throw new InvalidOperationException();
            return FindMax(root);
        }

        private int FindMax(Node root)
        {
            if (root.rightChild == null)
                return root.val;

            return FindMax(root.rightChild);
        }


    }
}