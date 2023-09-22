
using System.Runtime.ConstrainedExecution;
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
                return string.Empty;

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
                return string.Empty;

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
                return string.Empty;

            var seen = new HashSet<char>();
            var sb = new StringBuilder();

            foreach (var ch in inputString)
            {
                if (seen.Contains(ch))
                    continue;
                seen.Add(ch);
                sb.Append(ch);
            }

            return sb.ToString();
        }

        public static char FindMostRepeatedChar(string inputString)
        {
            char maxCh = char.MinValue;
            if (string.IsNullOrEmpty(inputString))
                return maxCh;

            var frequencies = new Dictionary<char, int>
            {
                { char.MinValue, 0 }
            };

            foreach (var ch in inputString)
            {
                if (frequencies.ContainsKey(ch))
                    frequencies[ch]++;
                else
                    frequencies[ch] = 1;

                if (frequencies[maxCh] < frequencies[ch])
                    maxCh = ch;
            }

            return maxCh;
        }

        public static char FindMostRepeatedChar2(string inputString)
        {
            const int ASCII_SIZE = 256;
            int[] freq = new int[ASCII_SIZE];

            int maxCh = char.MinValue;
            if (string.IsNullOrEmpty(inputString))
                return (char)maxCh;

            foreach (var ch in inputString)
            {
                freq[ch]++;
                if (freq[maxCh] < freq[ch])
                    maxCh = ch;
            }

            return (char)maxCh;
        }

        public static string Capitalize(string inputString)
        {
            if (string.IsNullOrWhiteSpace(inputString))
                return string.Empty;

            var words = inputString.Trim().Split(" ");

            var sb = new StringBuilder();
            foreach (var word in words)
            {
                if (string.IsNullOrWhiteSpace(word))
                    continue;

                var cap = word[..1].ToString().ToUpper() + word[1..];
                sb.Append(cap);
                sb.Append(' ');
            }
            sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }

        //A string is an anagram of another string if it has the exact same characters in any order.
        //O(n)
        public static bool AreAnagram(string inputString1, string inputString2)
        {
            if (string.IsNullOrEmpty(inputString1) || string.IsNullOrEmpty(inputString2))
                return false;


            if (inputString1.Length != inputString2.Length)
                return false;

            var wordsMap = new Dictionary<char, int>();

            //O(n)
            foreach (var ch in inputString1.ToLower())
                if (wordsMap.ContainsKey(ch))
                    wordsMap[ch]++;
                else
                    wordsMap[ch] = 1;

            //O(n)
            foreach (var ch in inputString2.ToLower())
            {
                if (wordsMap.ContainsKey(ch))
                {
                    wordsMap[ch]--;
                    if (wordsMap[ch] <= 0)
                        wordsMap.Remove(ch);
                }
                else
                    return false;
            }

            return true;
        }

        //O(n log n)
        public static bool AreAnagram2(string inputString1, string inputString2)
        {
            if (string.IsNullOrEmpty(inputString1) || string.IsNullOrEmpty(inputString2))
                return false;

            if (inputString1.Length != inputString2.Length)
                return false;

            //O(n)
            var chArr1 = inputString1.ToCharArray();
            var chArr2 = inputString2.ToCharArray();

            //O(n log n)
            Array.Sort(chArr1);
            Array.Sort(chArr2);

            //O(n)
            for (int i = 0; i < chArr1.Length; i++)
            {
                if (chArr1[i] != chArr2[i])
                    return false;
            }

            return true;
        }

        public static bool IsPalindrome(string inputString)
        {
            if (string.IsNullOrEmpty(inputString))
                return false;

            for (int i = 0; i < inputString.Length / 2; i++)
            {
                if (inputString[i] != inputString[inputString.Length - 1 - i])
                    return false;
            }

            return true;
        }
    }
}