namespace DSA.Part1.BinaryTrees
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

            if (IsLeef(root))
                return 0;

            return 1 + Math.Max(Height(root.leftChild), Height(root.rightChild));
        }

        public int FindMin()
        {
            return FindMin(root);
        }

        private int FindMin(Node root)
        {
            if (root == null)
                return int.MaxValue;

            if (IsLeef(root))
                return root.val;


            int leftMin = FindMin(root.leftChild);
            int rightMin = FindMin(root.rightChild);
            return Math.Min(root.val, Math.Min(leftMin, rightMin));
        }

        private bool IsLeef(Node node)
        {
            return root.leftChild == null && root.rightChild == null;
        }
    }
}