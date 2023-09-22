
namespace DSA.Part3.Searching
{
    public class BinarySearch
    {
        public static int Search(int[] inputArray, int num)
        {
            return Search(inputArray, num, 0, inputArray.Length);
        }

        public static int Search(int[] inputArray, int num, int start, int end)
        {
            if (end < start)
                return -1;

            int middle = (start + end) / 2;
            if (inputArray[middle] == num)
                return middle;

            if (inputArray[middle] > num)
                return Search(inputArray, num, start, middle - 1);
            else
                return Search(inputArray, num, middle + 1, end);
        }

        public static int SearchIt(int[] inputArray, int num)
        {
            int left = 0;
            int right = inputArray.Length - 1;

            while (left <= right)
            {
                int middle = (left + right) / 2;
                if (num == inputArray[middle])
                    return middle;

                if (inputArray[middle] > num)
                    right = middle - 1;
                else
                    left = middle + 1;
            }

            return -1;
        }
    }
}