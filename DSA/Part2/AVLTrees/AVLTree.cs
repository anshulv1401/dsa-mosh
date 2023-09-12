using DSA.Part2;

namespace DSA.Part1.AVLTrees
{

    public class AVLTree
    {
        public AVLNode root;

        public void Insert(int value)
        {
            root = Insert(root, value);
        }

        // private void Insert(AVLNode root, int value)
        // {
        //     if (root.val > value)
        //     {
        //         if (root.leftChild == null)
        //             root.leftChild = new AVLNode(value);
        //         else
        //             Insert(root.leftChild, value);
        //     }
        //     else
        //     {
        //         if (root.rightChild == null)
        //             root.rightChild = new AVLNode(value);
        //         else
        //             Insert(root.rightChild, value);
        //     }
        // }

        private AVLNode Insert(AVLNode root, int value)
        {
            if (root == null)
                return new AVLNode(value);

            if (root.val > value)
                root.leftChild = Insert(root.leftChild, value);
            else
                root.rightChild = Insert(root.rightChild, value);

            root.height = Math.Max(root.leftChild?.height ?? 0, root.rightChild?.height ?? 0) + 1;
            return root;
        }

        public void LevelOrderTraversal()
        {
            var dict = new Dictionary<int, List<AVLNode>>();
            LevelOrderTraversal(root, 0, dict);
            foreach (var entry in dict)
            {
                foreach (var node in entry.Value)
                    Console.Write("NodeVal->" + node.val + "(" + node.height + ")");
                Console.WriteLine();
            }
        }

        private void LevelOrderTraversal(AVLNode root, int height, Dictionary<int, List<AVLNode>> dict)
        {
            if (root == null)
                return;

            if (dict.ContainsKey(height))
                dict[height].Add(root);
            else
                dict.Add(height, new List<AVLNode>() { root });

            LevelOrderTraversal(root.leftChild, height + 1, dict);
            LevelOrderTraversal(root.rightChild, height + 1, dict);
        }
    }
}