namespace DSA.Part1.HashTables
{
    //HashTable
    //Linear probing
    //LinkedList<KeyValuePair<int, string>>
    public class CustomHashTableLinearProbling
    {
        private class Entry
        {
            public Entry(int Key, string Value)
            {
                this.Key = Key;
                this.Value = Value;
            }
            public int Key;
            public string Value;
        }

        readonly Entry[] map;
        public int Size
        {
            get; private set;
        }

        public CustomHashTableLinearProbling(int size)
        {
            map = new Entry[size];
            Size = 0;
        }
        //Put (k,v)
        public void Put(int key, string value)
        {
            var entry = GetEntry(key);
            if (entry != null)
                throw new InvalidOperationException("Key already exists");

            if (IsFull())
                throw new InvalidOperationException("Map is full");

            map[GetIndex(key)] = new Entry(key, value);
            Size++;
        }

        //Get (k):v
        public string? Get(int key)
        {
            var entry = GetEntry(key);
            if (entry != null)
                return entry.Value;
            throw new InvalidOperationException(key + " key not found");
        }

        public string? Remove(int key)
        {
            var index = GetIndex(key);
            if (map[index] == null)
                throw new InvalidOperationException(key + " key not found");
            var val = map[index].Value;
            map[index] = null;
            Size--;
            return val;
        }

        private Entry? GetEntry(int key)
        {
            int index = GetIndex(key);
            return index >= 0 ? map[index] : null;
        }

        private int GetIndex(int key)
        {
            int count = 0;
            while (count < map.Length)
            {
                int index = HashIndex(key, count++);
                var entry = map[index];
                //If empty block found or match with the key found
                if (entry == null || entry.Key == key)
                    return index;
            }

            // the table is full.
            return -1;
        }

        private bool IsFull()
        {
            return Size == map.Length;
        }

        private int HashIndex(int key, int i)
        {
            return (HashFunction(key) + i) % map.Length;
        }

        private int HashFunction(int key)
        {
            return Math.Abs(key) % map.Length;
        }

        public void PrintHashTable()
        {
            Console.WriteLine("------------------------");
            foreach (var entry in map)
                Console.WriteLine("[" + entry?.Key + "," + entry?.Value + "]");
            Console.WriteLine("Size is:" + Size);
            Console.WriteLine("------------------------");
        }
    }
}