namespace DSA.Dictionary
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


            HashSet<int> set = new();
            set.Add(1);
            set.Add(1); // allowed
            set.Add(2);
            set.Add(3);
            Console.WriteLine(string.Join(",", set));

        }

        // Input A Green Apple
        // Output G
        public static char FirstNonRepeatedCharacter(string input)
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
        public static char FirstRepeatedCharacter(string input)
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
    }
}