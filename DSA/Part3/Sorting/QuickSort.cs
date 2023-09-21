
namespace DSA.Part3.Sorting
{
    public class QuickSort
    {
        public static void Sort(int[] inputArray)
        {
            Sort(inputArray, 0, inputArray.Length - 1);
        }

        private static void Sort(int[] inputArray, int start, int end)
        {
            if (start >= end)
                return;

            var boundary = Partition(inputArray, start, end);
            Sort(inputArray, start, boundary - 1);
            Sort(inputArray, boundary + 1, end);
        }

        private static int Partition(int[] inputArray, int start, int end)
        {
            var pivot = inputArray[end];
            var boundary = start - 1;
            for (int i = start; i <= end; i++)
            {
                if (inputArray[i] <= pivot)
                {
                    boundary++;
                    (inputArray[i], inputArray[boundary]) = (inputArray[boundary], inputArray[i]);
                }
            }

            return boundary;
        }
    }
}