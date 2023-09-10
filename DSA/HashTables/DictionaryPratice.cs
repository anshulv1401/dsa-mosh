namespace DSA.HashTables
{

    public class DictionaryPratice
    {

        public static void DemoDisctionary()
        {
            Dictionary<string, string> dictionary = new();

            dictionary.Add("hello", "asdf");
            dictionary.TryAdd("hello", "asdf");
            dictionary.Add("asdf", "asdf");
            dictionary.Add("fdsa", "asdf");
            // dictionary.Add("fdsa", "asdf"); // Exception as same key already exists
            dictionary.Add("123", null); // Allowed
            // dictionary.Add(null, "asdf"); // Exception as key is null
            dictionary.Remove("asdf");

            Console.WriteLine(string.Join(",", dictionary));
            // Console.WriteLine(dictionary["asdf"]); // Exception as 'asdf' was not present
            Console.WriteLine(dictionary.TryGetValue("asdf", out string asdf));
            Console.WriteLine(dictionary["fdsa"]);

            Console.WriteLine(dictionary.ContainsKey("asdf")); // O(1) operation
            Console.WriteLine(dictionary.ContainsValue("asdf")); // O(n) operation

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }

            string str = "asdf";
            Console.WriteLine(str.GetHashCode());

            HashSet<int> set = new()
            {
                1,
                1, // allowed
                2,
                3
            };
            Console.WriteLine(string.Join(",", set));

        }

        // Input A Green Apple
        // Output G
        public static char FirstNonRepeatedCharacterInString(string input)
        {
            var dics = new Dictionary<char, int>();
            foreach (char character in input)
            {
                if (!dics.ContainsKey(character))
                {
                    dics.Add(character, 1);
                    continue;
                }
                dics[character]++;
            }

            foreach (char character in input)
            {
                if (dics[character] == 1)
                    return character;
            }
            return char.MinValue;
        }

        // Input Green Apple
        // Output e
        public static char FirstRepeatedCharacterInAString(string input)
        {
            var set = new HashSet<char>();
            foreach (char character in input)
            {
                if (set.Contains(character))
                    return character;
                set.Add(character);
            }
            return char.MinValue;
        }

        // Find the most repeated element in a array in integers
        public static int FindMostRepeatedElementArrayOfInt(int[] inputArray)
        {
            if (inputArray.Length == 0)
                return 0;

            Dictionary<int, int> dictionary = new();
            int indexOfMaxCount = -1;
            foreach (var integer in inputArray)
            {
                if (dictionary.ContainsKey(integer))
                    dictionary[integer]++;
                else
                    dictionary[integer] = 1;

                if (indexOfMaxCount == -1)
                    indexOfMaxCount = integer;
                else if (dictionary[indexOfMaxCount] < dictionary[integer])
                    indexOfMaxCount = integer;

            }
            return indexOfMaxCount;
        }

        // O(n^2)
        // Count the number of unique pairs of integers that have difference K.
        public static int CountPairsWithDiff(int[] inputArray, int k)
        {
            var set = new HashSet<string>();
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    int first = inputArray[i];
                    int second = inputArray[j];
                    if (Math.Abs(first - second) == k)
                    {
                        string key = first < second ? first + "" + second : second + "" + first;
                        set.Add(key);
                    }
                }
            }
            return set.Count;
        }

        // O(2n) ~ O(n)
        // Count the number of unique pairs of integers that have difference K.
        public static int CountPairsWithDiff2(int[] inputArray, int k)
        {
            var set = new HashSet<int>();

            foreach (int item in inputArray)
                set.Add(item);

            int count = 0; ;
            foreach (int item in inputArray)
            {
                if (set.Contains(item - k))
                    count++;

                if (set.Contains(item + k))
                    count++;

                set.Remove(item);
            }

            return count;
        }

        //return indices of the two numbers such that they add up to a specific target.
        public static Tuple<int, int> TwoSum(int[] inputArray, int target)
        {
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < inputArray.Length; i++)
                dict.TryAdd(inputArray[i], i);


            for (int i = 0; i < inputArray.Length; i++)
            {
                if (dict.ContainsKey(target - inputArray[i]) && dict[target - inputArray[i]] != i)
                    return new Tuple<int, int>(i, dict[target - inputArray[i]]);
            }

            return null;
        }

        //return indices of the two numbers such that they add up to a specific target.
        public static Tuple<int, int> TwoSum2(int[] inputArray, int target)
        {
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (dict.ContainsKey(target - inputArray[i]) && dict[target - inputArray[i]] != i)
                    return new Tuple<int, int>(i, dict[target - inputArray[i]]);
                dict.TryAdd(inputArray[i], i);
            }

            return null;
        }
    }
}