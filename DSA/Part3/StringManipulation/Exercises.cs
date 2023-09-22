
using System.Text;

namespace DSA.Part3.StringManipulation
{
    public class Exercises
    {
        public static int FindNumberOfVowels(string inputStr)
        {
            if (string.IsNullOrWhiteSpace(inputStr))
                return 0;

            HashSet<char> vowels = new() { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O' };
            int count = 0;

            foreach (char ch in inputStr)
            {
                if (vowels.Contains(ch))
                    count++;
            }
            return count;
        }

        public static string ReverseAString(string inputStr)
        {
            if (string.IsNullOrWhiteSpace(inputStr))
                return "";

            // var chArr = inputStr.ToCharArray();
            // return new String(chArr.Reverse().ToArray());

            StringBuilder sb = new();
            for (int i = inputStr.Length - 1; i >= 0; i--)
                sb.Append(inputStr[i]);

            return sb.ToString();
        }

        public static string ReverseWords(string inputWords)
        {
            if (string.IsNullOrWhiteSpace(inputWords))
                return "";

            var words = inputWords.Trim().Split(" ");

            // var wordArr = words.Reverse();
            // return string.Join(" ", wordArr);

            var sb = new StringBuilder();
            for (int i = words.Length - 1; i >= 0; i--)
            {
                sb.Append(words[i]);
                sb.Append(' ');
            }

            return sb.ToString().Trim();
        }


        public static bool IsRotation(string inputString1, string inputString2)
        {
            if (string.IsNullOrEmpty(inputString1) || string.IsNullOrEmpty(inputString2))
                return false;

            if (inputString1.Length != inputString2.Length)
                return false;

            int i = 0;
            int length = inputString1.Length;
            for (; i <= length; i++)
            {
                if (i == length)
                    return false;

                if (inputString2[i] == inputString1[0])
                    break;
            }

            i++;
            for (int j = 1; j < length; j++)
            {
                i = (i == length) ? 0 : i;

                if (inputString1[j] != inputString2[i])
                    return false;
                i++;
            }

            return true;
        }

        //require extra space
        public static bool IsRotation2(string inputString1, string inputString2)
        {
            if (string.IsNullOrEmpty(inputString1) || string.IsNullOrEmpty(inputString2))
                return false;

            if (inputString1.Length != inputString1.Length)
                return false;

            return (inputString1 + inputString1).Contains(inputString2);
        }

        public static string RemoveDuplicateCharacters(string inputString)
        {
            if (string.IsNullOrEmpty(inputString))
                return "";

            var set = new HashSet<char>();
            var sb = new StringBuilder();

            foreach (var ch in inputString)
            {
                if (set.Contains(ch))
                    continue;
                set.Add(ch);
                sb.Append(ch);
            }

            return sb.ToString();
        }
    }
}