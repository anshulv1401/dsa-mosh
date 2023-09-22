
namespace DSA.Part3.Searching
{
    public class JumpSearch
    {
        public static int Search(int[] inputArray, int target)
        {
            int blockSize = (int)Math.Sqrt(inputArray.Length);
            int start = 0;
            int next = blockSize;

            while (target > inputArray[next - 1])
            {
                start = next;

                if (start >= inputArray.Length)
                    return -1;

                next += blockSize;
                if (next >= inputArray.Length)
                    next = inputArray.Length;
            }

            while (start < next)
            {
                if (target == inputArray[start])
                    return start;
                start++;
            }
            return -1;
        }
    }
}