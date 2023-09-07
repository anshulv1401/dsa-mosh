using System.Text;

namespace DSA.Stacks
{
    public class StackPractice
    {
        private readonly Dictionary<char, char> brackets = new() { { ')', '(' } };

        public StackPractice()
        {
            brackets.Add('>', '<');
            brackets.Add(']', '[');
            brackets.Add('}', '{');
        }
        public string ReverseAString(string str)
        {
            if (str == null)
                throw new ArgumentNullException("str");
            Stack<char> stack = new();

            foreach (char c in str)
                stack.Push(c);

            StringBuilder sb = new();
            foreach (char c in stack)
                sb.Append(c);

            return sb.ToString();
        }

        public bool IsBalancedExpression(string str)
        {
            if (str == null)
                throw new ArgumentNullException("str");

            Stack<char> stack = new();
            foreach (char c in str)
            {
                if (brackets.ContainsValue(c))
                    stack.Push(c);
                else if (brackets.ContainsKey(c))
                {
                    if (stack.Count == 0 || stack.Pop() != brackets[c])
                        return false;
                }
            }
            return stack.Count == 0;
        }
    }
}
