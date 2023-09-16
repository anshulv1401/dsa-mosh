namespace DSA.Part2.Tries
{
    //Node
    //  Value : Char
    //  children: Node[26]
    //  IsEndOfWord: boolean
    public class TrieNode
    {
        public char Value { get; private set; }
        private readonly Dictionary<char, TrieNode> children;
        public bool isEndOfWord;

        public TrieNode(char value)
        {
            this.Value = value;
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
            return "Value:" + Value;
        }
    }
}