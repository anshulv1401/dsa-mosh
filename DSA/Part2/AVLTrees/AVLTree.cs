using DSA.Part2;

namespace DSA.Part2.AVLTrees
{

    public class AVLTree
    {
        private class Node
        {
            public Node(int val)
            {
                this.val = val;
            }

            public int val;
            public int height;
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
            root = Insert(root, value);
        }


        private Node Insert(Node root, int value)
        {
            if (root == null)
                return new Node(value);

            if (root.val > value)
                root.leftChild = Insert(root.leftChild, value);
            else
                root.rightChild = Insert(root.rightChild, value);

            SetHeight(root);
            return Balance(root);
        }


        // BalanceFactor = height(L) - height(R)
        // if bf > 1 --> left heavy --> right rotation
        // if bf < -1 --> right heavy --> left rotation

        //10
        //  20
        //      30
        //leftRotate(10)

        //10
        //  20
        //30
        //rightRotate(30)
        //leftRotate(10)

        //      10
        //  20
        //30
        //rightRotate(10)

        //  10
        //20
        //  30
        //leftRotate(30)
        //rightRotate(10)
        private Node Balance(Node root)
        {
            if (IsLeftHeavy(root))
            {
                if (BalanceFactor(root.leftChild) < 0)
                    root.leftChild = RotateLeft(root.leftChild);
                return RotateRight(root);
            }
            else if (IsRightHeavy(root))
            {
                if (BalanceFactor(root.rightChild) > 0)
                    root.rightChild = RotateRight(root.rightChild);
                return RotateLeft(root);
            }
            return root;
        }

        //Rotate left
        private Node RotateLeft(Node root)
        {
            var newRoot = root.rightChild;
            root.rightChild = newRoot.leftChild;
            newRoot.leftChild = root;

            SetHeight(root);
            SetHeight(newRoot);
            return newRoot;
        }

        //Rotate right
        private Node RotateRight(Node root)
        {
            var newRoot = root.leftChild;
            root.leftChild = newRoot.rightChild;
            newRoot.rightChild = root;

            SetHeight(root);
            SetHeight(newRoot);
            return newRoot;
        }

        private bool IsLeftHeavy(Node root)
        {
            return BalanceFactor(root) > 1;
        }

        private bool IsRightHeavy(Node root)
        {
            return BalanceFactor(root) < -1;
        }

        private int BalanceFactor(Node root)
        {
            if (root == null)
                return 0;
            return Height(root.leftChild) - Height(root.rightChild);
        }

        private void SetHeight(Node root)
        {
            root.height = Math.Max(Height(root.leftChild), Height(root.rightChild)) + 1;
        }

        private int Height(Node node)
        {
            return node?.height ?? -1;
        }

        public void LevelOrderTraversal()
        {
            var dict = new Dictionary<int, List<Node>>();
            LevelOrderTraversal(root, 0, dict);
            foreach (var entry in dict)
            {
                foreach (var node in entry.Value)
                    Console.Write("NodeVal->" + node.val + "(" + node.height + ")");
                Console.WriteLine();
            }
        }

        private void LevelOrderTraversal(Node root, int height, Dictionary<int, List<Node>> dict)
        {
            if (root == null)
                return;

            if (dict.ContainsKey(height))
                dict[height].Add(root);
            else
                dict.Add(height, new List<Node>() { root });

            LevelOrderTraversal(root.leftChild, height + 1, dict);
            LevelOrderTraversal(root.rightChild, height + 1, dict);
        }
    }
}