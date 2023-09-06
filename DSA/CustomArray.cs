namespace DSA
{
    public class CustomArray
    {
        private int[] array;
        private int lastIndex = -1;
        public CustomArray(int size)
        {
            array = new int[size];
        }

        public void Print()
        {
            for (int i = 0; i <= lastIndex; i++)
                Console.WriteLine(array[i]);
        }

        public void Insert(int item)
        {
            if (array.Length == lastIndex + 1)
            {
                var newArray = new int[array.Length * 2];
                for (int i = 0; i < array.Length; i++)
                    newArray[i] = array[i];
                array = newArray;
            }
            lastIndex++;
            array[lastIndex] = item;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > lastIndex)
            {
                throw new ArgumentOutOfRangeException("index");
            }

            for (int i = index; i < array.Length - 1; i++)
                array[i] = array[i + 1];

            lastIndex--;
        }

        public int IndexOf(int item)
        {
            return Array.IndexOf(array, item);
        }
    }
}