namespace DSA.Part2.Tries
{
    public class TrieTree
    {
        //Node
        //  Value : Char
        //  children: Node[26]
        //  IsEndOfWord: boolean
        public static int ALPHABET_SIZE = 26;
        private class TrieNode
        {
            char value;
            private readonly Dictionary<char, TrieNode> children;
            public bool isEndOfWord;

            public TrieNode(char value)
            {
                this.value = value;
                children = new Dictionary<char, TrieNode>();
                isEndOfWord = false;
            }

            public TrieNode GetChild(char ch)
            {
                return children[ch];
            }

            public bool HasChild(char ch)
            {
                return children.ContainsKey(ch);
            }

            public void AddChild(char ch)
            {
                children.Add(ch, new TrieNode(ch));
            }

            public TrieNode[] GetChildren()
            {
                return children.Values.ToArray();
            }

            public override string ToString()
            {
                return "Value:" + value;
            }
        }

        readonly TrieNode rootNode = new(' ');
        public void Insert(string word)
        {
            TrieNode current = rootNode;
            foreach (char ch in word)
            {
                if (!current.HasChild(ch))
                    current.AddChild(ch);
                current = current.GetChild(ch);
            }
            current.isEndOfWord = true;
        }

        public bool Contains(string word)
        {
            if (word == null)
                return false;

            TrieNode current = rootNode;

            foreach (char ch in word)
            {
                if (!current.HasChild(ch))
                    return false;
                current = current.GetChild(ch);
            }
            return current.isEndOfWord;
        }

        public void Traverse()
        {
            Traverse(rootNode);
        }

        private void Traverse(TrieNode root)
        {
            Console.WriteLine(root.ToString());
            foreach (var child in root.GetChildren())
            {
                Traverse(child);
            }
        }
        //index = ch - 'a'> eg 'd' - 'a' = 100 - 97 = 3
        private static int CharaterIndex(char ch)
        {
            int chAccii = ch < 'a' ? ch + ('a' - 'A') : ch;
            return chAccii - 'a';
        }
    }
}