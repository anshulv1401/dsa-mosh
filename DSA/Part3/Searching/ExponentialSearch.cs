
namespace DSA.Part3.Searching
{
    public class ExponentialSearch
    {
        public static int Search(int[] inputArray, int target)
        {
            int bound = 1;
            while (bound < inputArray.Length && inputArray[bound] > target)
                bound *= 2;

            int left = bound / 2;
            int right = Math.Min(bound, inputArray.Length);
            return BinarySearch.Search(inputArray, target, left, right);
        }
    }
}