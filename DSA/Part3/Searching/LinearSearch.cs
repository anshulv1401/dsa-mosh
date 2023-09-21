
namespace DSA.Part3.Searching
{
    public class LinearSearch
    {
        public static int Search(int[] inputArray, int num)
        {
            for (int i = 0; i < inputArray.Length; i++)
                if (inputArray[i] == num)
                    return i;
            return -1;
        }
    }
}