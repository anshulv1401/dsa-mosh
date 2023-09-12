namespace DSA.Part2
{
    public class AVLNode
    {
        public AVLNode(int val)
        {
            this.val = val;
        }

        public int val;
        public int height;
        public AVLNode leftChild;
        public AVLNode rightChild;

        public override string ToString()
        {
            return "Node:" + val;
        }
    }
}