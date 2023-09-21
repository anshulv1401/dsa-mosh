
namespace DSA.Part3.Sorting
{
    public class SortingAlgo
    {

        public static void BubbleSort(int[] inputArray)
        {
            bool isSorted;
            for (int i = 0; i < inputArray.Length; i++)
            {
                isSorted = true;
                for (int j = 0; j < inputArray.Length - i - 1; j++)
                {
                    if (inputArray[j] > inputArray[j + 1])
                    {
                        (inputArray[j], inputArray[j + 1]) = (inputArray[j + 1], inputArray[j]);
                        isSorted = false;
                    }
                }
                if (isSorted)
                    return;
            }
        }

        public static void SelectionSort(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                int minIndex = i;
                for (int j = i; j < inputArray.Length; j++)
                {
                    if (inputArray[minIndex] > inputArray[j])
                        minIndex = j;
                }
                (inputArray[i], inputArray[minIndex]) = (inputArray[minIndex], inputArray[i]);
            }
        }

        public static void InsertionSort(int[] inputArray)
        {
            for (int i = 1; i < inputArray.Length; i++)
            {
                if (inputArray[i - 1] <= inputArray[i])
                    continue;

                int current = inputArray[i];

                int j = i - 1;
                for (; j >= 0; j--)
                {
                    if (inputArray[j] <= current)
                        break;
                    inputArray[j + 1] = inputArray[j];
                }
                inputArray[j + 1] = current;
            }
        }
    }
}