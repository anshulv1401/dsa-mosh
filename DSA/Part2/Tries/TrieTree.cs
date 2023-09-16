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

            public TrieNode GetChild(char key)
            {
                return children[key];
            }

            public bool HasChild(char key)
            {
                return children.ContainsKey(key);
            }

            public void AddChild(char key)
            {
                children.Add(key, new TrieNode(key));
            }

            public TrieNode[] GetChildren()
            {
                return children.Values.ToArray();
            }

            public bool HasChildren()
            {
                return children.Count != 0;
            }

            public void RemoveChild(char key)
            {
                children.Remove(key);
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


        public void Remove(string word)
        {
            if (word == null)
                return;
            Remove(rootNode, word, 0);
        }

        private void Remove(TrieNode root, string word, int index)
        {
            if (index == word.Length)
            {
                root.isEndOfWord = false;
                return;
            }

            if (!root.HasChild(word[index]))
                return;

            var childNode = root.GetChild(word[index]);
            Remove(childNode, word, index + 1);
            if (childNode.HasChildren() && !childNode.isEndOfWord)
            {
                root.RemoveChild(word[index]);
            }
        }


        // private void Remove(TrieNode node, string word, int index)
        // {
        //     if (!node.HasChild(word[index]))
        //     {
        //         Console.WriteLine(node.ToString());
        //         return;
        //     }

        //     var nextCharNode = node.GetChild(word[index]);

        //     if (word.Length - 1 == index)
        //     {
        //         nextCharNode.isEndOfWord = false;
        //         Console.WriteLine(node.ToString());
        //         return;
        //     }

        //     Remove(nextCharNode, word, index + 1);
        //     Console.WriteLine(node.ToString());
        // }


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