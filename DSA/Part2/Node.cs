namespace DSA.Part1
{
    public class Node
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
}