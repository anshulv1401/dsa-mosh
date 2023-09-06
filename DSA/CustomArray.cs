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
            AutoIncrementArrayIfRequired();
            array[lastIndex] = item;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > lastIndex)
            {
                throw new ArgumentOutOfRangeException("index");
            }

            for (int i = index; i < lastIndex; i++)
                array[i] = array[i + 1];

            lastIndex--;
        }

        public int IndexOf(int item)
        {
            return Array.IndexOf(array, item);
        }

        public int Max()
        {
            int max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            return max;
        }

        public int[] Intersect(int[] array)
        {
            var commonArray = new CustomArray(array.Length);
            for (int i = 0; i < this.array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (this.array[i] == array[j])
                    {
                        commonArray.Insert(array[j]);
                    }
                }
            }
            return commonArray.ToArray();
        }

        public void ReverseArray()
        {
            for (int i = 0; i < ((lastIndex + 1) / 2); i++)
            {
                (array[lastIndex - i], array[i]) = (array[i], array[lastIndex - i]);
            }
        }

        public void InsertAt(int index, int item)
        {
            if (index < 0 || index > lastIndex)
            {
                throw new ArgumentOutOfRangeException("index");
            }

            AutoIncrementArrayIfRequired();

            for (int i = lastIndex; i >= index; i--)
                array[i + 1] = array[i];
            array[index] = item;
        }

        private void AutoIncrementArrayIfRequired()
        {
            if (array.Length == lastIndex + 1)
            {
                var newArray = new int[array.Length * 2];
                for (int i = 0; i < array.Length; i++)
                    newArray[i] = array[i];
                array = newArray;
            }
            lastIndex++;
        }

        public int[] ToArray()
        {
            int[] newArray = new int[lastIndex + 1];
            for (int i = 0; i <= lastIndex; i++)
                newArray[i] = array[i];
            return newArray;
        }
    }
}