using System.Text;

namespace DSA.Part1.Stacks
{
    // Design a stack that supports push, pop and retrieving the minimum value in constant time.
    public class CustomMinStack2
    {
        private readonly int[] stack;
        private int minVal;
        int lastIndex = -1;
        int lastMinIndex = -1;

        public CustomMinStack2()
        {
            stack = new int[10];
        }
        //Push

        public void Push(int item)
        {
            if (lastIndex == stack.Length - 1)
                throw new StackOverflowException();

            if (lastMinIndex == -1)
            {
                stack[++lastIndex] = item;
                minVal = item;
                return;
            }

            if (minVal > item)
            {
                stack[++lastIndex] = item * 2 - minVal;
                minVal = item;
            }
            else
                stack[++lastIndex] = item;
        }

        //Pop
        public int Pop()
        {
            if (lastIndex == -1)
                throw new IndexOutOfRangeException();

            int lastItem = stack[lastIndex--];

            if (minVal > lastItem)
            {
                var originalLastItem = minVal;
                minVal = 2 * minVal - lastItem;
                return originalLastItem;
            }
            else
                return lastItem;
        }

        //Peek

        public int Peek()
        {
            if (lastIndex == -1)
                throw new IndexOutOfRangeException();

            if (stack[lastIndex] < minVal)
            {
                return minVal;
            }
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
            return minVal;
        }
        public override string ToString()
        {
            var array = new int[lastIndex + 1];
            Array.Copy(stack, array, lastIndex + 1);
            return string.Join(',', array);
        }
    }
}
