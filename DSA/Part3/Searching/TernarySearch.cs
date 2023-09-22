namespace DSA.Part3.Searching
{

    public class TernarySearch
    {

        //Partition size = (right - left)/3
        public static int Search(int[] inputArray, int target)
        {
            return Search(inputArray, target, 0, inputArray.Length - 1);
        }

        private static int Search(int[] inputArray, int target, int start, int end)
        {
            if (start > end)
                return -1;

            int size = (end - start) / 3;
            int mid1 = start + size;
            int mid2 = end - size;

            if (inputArray[mid2] < target)
                return Search(inputArray, target, mid2 + 1, end);

            if (inputArray[mid2] == target)
                return mid2;

            if (inputArray[mid1] > target)
                return Search(inputArray, target, mid1 + 1, mid2 - 1); ;

            if (inputArray[mid1] == target)
                return mid1;

            return Search(inputArray, target, start, mid1 - 1);
        }
    }
}