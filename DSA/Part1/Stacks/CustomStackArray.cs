using System.Text;

namespace DSA.Part1.Stacks
{
    public class CustomStackArray
    {
        private int[] stack;
        int lastIndex = -1;

        public CustomStackArray()
        {
            stack = new int[10];
        }
        //Push

        public void Push(int item)
        {
            if (lastIndex == stack.Length - 1)
                throw new StackOverflowException();
            stack[++lastIndex] = item;
        }

        //Pop
        public int Pop()
        {
            if (lastIndex == -1)
                throw new IndexOutOfRangeException();

            int lastItem = stack[lastIndex--];
            return lastItem;
        }

        //Peek

        public int Peek()
        {
            if (lastIndex == -1)
                throw new IndexOutOfRangeException();

            return stack[lastIndex];
        }

        //IsEmpty

        public bool IsEmpty()
        {
            return lastIndex == -1;
        }

        public override string ToString()
        {
            var array = new int[lastIndex + 1];
            Array.Copy(stack, array, lastIndex + 1);
            return string.Join(',', array);
        }
    }
}
