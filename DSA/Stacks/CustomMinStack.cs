using System.Text;

namespace DSA.Stacks
{
    // Design a stack that supports push, pop and retrieving the minimum value in constant time.
    public class CustomMinStack
    {
        private readonly int[] stack;
        private readonly int[] minStack;
        int lastIndex = -1;
        int lastMinIndex = -1;

        public CustomMinStack()
        {
            stack = new int[10];
            minStack = new int[10];
        }
        //Push

        public void Push(int item)
        {
            if (lastIndex == stack.Length - 1)
                throw new StackOverflowException();
            stack[++lastIndex] = item;

            if (lastMinIndex == -1 || minStack[lastMinIndex] > item)
            {
                minStack[++lastMinIndex] = item;
            }
        }

        //Pop
        public int Pop()
        {
            if (lastIndex == -1)
                throw new IndexOutOfRangeException();

            int lastItem = stack[lastIndex--];

            if (minStack[lastMinIndex] == lastItem)
                --lastMinIndex;

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


        //IsEmpty
        public int Min()
        {
            if (lastIndex == -1)
                throw new IndexOutOfRangeException();
            return minStack[lastMinIndex];
        }
        public override string ToString()
        {
            var array = new int[lastIndex + 1];
            Array.Copy(stack, array, lastIndex + 1);
            return string.Join(',', array);
        }
    }
}
