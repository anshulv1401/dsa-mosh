
namespace DSA.Part3.Sorting
{
    public class MergeSort
    {
        public static void Sort(int[] inputArray)
        {
            if (inputArray.Length <= 1)
                return;

            int middle = inputArray.Length / 2;
            var leftArray = new int[middle];

            for (var i = 0; i < middle; i++)
                leftArray[i] = inputArray[i];

            var rightArray = new int[inputArray.Length - middle];
            for (var i = middle; i < inputArray.Length; i++)
                rightArray[i - middle] = inputArray[i];

            Sort(leftArray);
            Sort(rightArray);

            Merge(leftArray, rightArray, inputArray);
        }

        private static void Merge(int[] leftArray, int[] rightArray, int[] result)
        {
            int i = 0, j = 0, k = 0;
            while (i < leftArray.Length && j < rightArray.Length)
            {
                if (leftArray[i] <= rightArray[j])
                    result[k++] = leftArray[i++];
                else
                    result[k++] = rightArray[j++];
            }

            while (i < leftArray.Length)
                result[k++] = leftArray[i++];
            while (j < rightArray.Length)
                result[k++] = rightArray[j++];
        }
    }
}