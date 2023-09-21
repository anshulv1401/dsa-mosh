
namespace DSA.Part3.Sorting
{
    public class BucketSort
    {
        public static void Sort(int[] inputArray, int numberOfBuckets)
        {
            var buckets = new List<int>[numberOfBuckets];

            foreach (var item in inputArray)
            {
                if (buckets[item / numberOfBuckets] == null)
                    buckets[item / numberOfBuckets] = new List<int>() { item };
                else
                    buckets[item / numberOfBuckets].Add(item);
            }

            int index = 0;
            foreach (var bucket in buckets)
            {
                if (bucket == null)
                    continue;
                bucket.Sort();
                foreach (var item in bucket)
                    inputArray[index++] = item;
            }
        }
    }
}