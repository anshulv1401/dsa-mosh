namespace DSA.Part2.Tries
{
    public class TrieTree
    {
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

        // public int CountWords(){

        // }

        public bool ContainsRecursively(string word)
        {
            if (string.IsNullOrEmpty(word))
                return false;

            return ContainsRecursively(rootNode, word, 0);
        }

        private bool ContainsRecursively(TrieNode rootNode, string word, int index)
        {
            if (word.Length == index)
                return rootNode.isEndOfWord;

            if (rootNode == null)
                return false;

            if (!rootNode.HasChild(word[index]))
                return false;

            var child = rootNode.GetChild(word[index]);
            return ContainsRecursively(child, word, index + 1);
        }

        public void Remove(string word)
        {
            if (word == null)
                return;
            Remove(rootNode, word, 0);
        }

        //Post Order traversal
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

            if (!childNode.HasChildren() && !childNode.isEndOfWord)
                root.RemoveChild(word[index]);
        }

        public List<string> FindWords(string prefix)
        {
            List<string> strings = new();

            var prefixNode = FindLastNodeOf(prefix);
            FindWords(prefixNode, prefix, strings);
            return strings;
        }

        private void FindWords(TrieNode rootNode, string prefix, List<string> words)
        {
            if (rootNode == null)
                return;

            if (rootNode.isEndOfWord)
                words.Add(prefix.Trim());


            foreach (var child in rootNode.GetChildren())
            {
                FindWords(child, prefix + child.Value, words);
            }
        }

        private TrieNode FindLastNodeOf(string prefix)
        {
            if (prefix == null)
                return null;

            var current = rootNode;
            foreach (var ch in prefix)
            {
                if (!current.HasChild(ch))
                    return null;
                current = current.GetChild(ch);
            }
            return current;
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