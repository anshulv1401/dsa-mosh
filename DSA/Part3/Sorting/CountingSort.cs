
namespace DSA.Part3.Sorting
{
    public class CountingSort
    {
        public static void Sort(int[] inputArray, int max)
        {
            int[] countsArray = new int[max + 1];

            foreach (var item in inputArray)
                countsArray[item]++;

            int index = 0;
            for (int i = 0; i < countsArray.Length; i++)
            {
                int count = countsArray[i];
                while (count > 0)
                {
                    inputArray[index++] = i;
                    count--;
                }
            }
        }

        public static void Sort(int[] inputArray, int min, int max)
        {
            int size = max - min + 1;

            int[] countsArray = new int[size];

            foreach (var item in inputArray)
                countsArray[item - min]++;

            int index = 0;
            for (int i = 0; i < countsArray.Length; i++)
            {
                int count = countsArray[i];
                while (count > 0)
                {
                    inputArray[index++] = min + i;
                    count--;
                }
            }
        }
    }
}