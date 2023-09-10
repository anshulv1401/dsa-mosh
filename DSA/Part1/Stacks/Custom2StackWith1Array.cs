using System.Text;

namespace DSA.Part1.Stacks
{
    // Implement two stacks in one array
    public class Custom2StackWith1Array
    {
        private int[] stack;
        int lastIndexOdd = -1; // 1,3,5,7,9
        int lastIndexEven = -2; // 0,2,4,6,8

        public Custom2StackWith1Array()
        {
            stack = new int[10];
        }
        //Push

        public void Push1(int item)
        {
            if (IsFull1())
                throw new StackOverflowException();
            lastIndexOdd += 2;
            stack[lastIndexOdd] = item;
        }

        public void Push2(int item)
        {
            if (IsFull2())
                throw new StackOverflowException();
            lastIndexEven += 2;
            stack[lastIndexEven] = item;
        }

        //Pop
        public int Pop1()
        {
            if (IsEmpty1())
                throw new IndexOutOfRangeException();

            int lastItem = stack[lastIndexOdd];
            lastIndexOdd -= 2;
            return lastItem;
        }


        public int Pop2()
        {
            if (IsEmpty2())
                throw new IndexOutOfRangeException();

            int lastItem = stack[lastIndexEven];
            lastIndexEven -= 2;
            return lastItem;
        }

        //Peek

        public int Peek1()
        {
            if (IsEmpty1())
                throw new IndexOutOfRangeException();

            return stack[lastIndexOdd];
        }

        public int Peek2()
        {
            if (IsEmpty2())
                throw new IndexOutOfRangeException();

            return stack[lastIndexEven];
        }

        //IsEmpty

        public bool IsEmpty1()
        {
            return lastIndexOdd == -1;
        }

        public bool IsEmpty2()
        {
            return lastIndexEven == -2;
        }

        //IsFull

        public bool IsFull1()
        {
            return lastIndexOdd == stack.Length - 1;
        }

        public bool IsFull2()
        {
            return lastIndexEven == stack.Length - 2;
        }

        public override string ToString()
        {
            var array = new int[lastIndexOdd + 1];
            Array.Copy(stack, array, lastIndexOdd + 1);
            return string.Join(',', array);
        }
    }
}
