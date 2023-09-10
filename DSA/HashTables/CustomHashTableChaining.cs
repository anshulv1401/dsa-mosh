using System.Linq.Expressions;

namespace DSA.HashTables
{
    //HashTable
    //Collisions chaining
    //LinkedList<KeyValuePair<int, string>>
    public class CustomHashTableChaining
    {
        readonly LinkedList<KeyValuePair<int, string>>[] map;

        public CustomHashTableChaining(int size)
        {
            map = new LinkedList<KeyValuePair<int, string>>[size];
        }
        //Put (k,v)
        public void Put(int key, string value)
        {

            var bucket = GetOrCreateBucket(key);
            foreach (var entry in bucket)
            {
                if (entry.Key == key)
                    throw new InvalidOperationException(key + " key already exists.");
            }
            bucket.AddLast(KeyValuePair.Create(key, value));
        }

        //Get (k):v
        public string? Get(int key)
        {
            var entry = GetEntry(key);
            return (entry?.Value) ?? null;
        }

        //Remove (k)
        public void Remove(int key)
        {
            var entry = GetEntry(key) ?? throw new InvalidOperationException(key + " key not found");
            int index = HashFunction(key);
            map[index].Remove(entry);
        }

        private KeyValuePair<int, string>? GetEntry(int key)
        {
            var bucket = GetBucket(key);
            if (bucket != null)
            {
                foreach (var item in bucket)
                {
                    if (item.Key == key)
                        return item;
                }
            }
            return null;
        }

        private LinkedList<KeyValuePair<int, string>> GetBucket(int key)
        {
            return map[HashFunction(key)];
        }

        private LinkedList<KeyValuePair<int, string>> GetOrCreateBucket(int key)
        {
            int index = HashFunction(key);
            if (map[index] == null)
                map[index] = new LinkedList<KeyValuePair<int, string>>();

            return map[index];
        }

        private int HashFunction(int key)
        {
            return Math.Abs(key) % map.Length;
        }

        public void PrintHashTable()
        {
            foreach (var ll in map)
            {
                if (ll != null)
                    foreach (var entry in ll)
                    {
                        Console.Write("-->[" + entry.Key + "," + entry.Value + "]");
                    }
                else
                    Console.Write("-->[,]");
                Console.WriteLine();
            }
        }
    }
}