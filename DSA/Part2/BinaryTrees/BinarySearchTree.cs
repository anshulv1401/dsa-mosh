namespace DSA.Part1.BinaryTrees
{

    public class BinarySearchTree
    {
        Node root;

        public void Insert(int value)
        {
            Node node = FindNode(value);
        }

        public bool Find(int value)
        {
            return FindNode(value) != null;
        }

        private Node FindNode(int value)
        {
            Node it = root;
            while (it != null)
            {
                if (it.val == value)
                    return it;
                else if (it.val > value)
                    it = it.leftChild;
                else
                    it = it.rightChild;
            }
            return null;
        }
    }
}