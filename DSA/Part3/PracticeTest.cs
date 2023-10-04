using System.Runtime.CompilerServices;

namespace DSA.Part3
{
    class PracticeTest
    {
        public static int CalPoints(string[] ops)
        {
            int sum = 0;
            int[] record = new int[ops.Length];
            int counter = -1;
            foreach (var op in ops)
            {
                if (op == "D")
                {
                    int temp = record[counter] * 2;
                    sum += temp;
                    record[++counter] = temp;
                    continue;
                }

                if (op == "+")
                {
                    int temp = record[counter] + record[counter - 1];
                    sum += temp;
                    record[++counter] = temp;
                    continue;
                }

                if (op == "C")
                {
                    int temp = record[counter - 1];
                    sum -= temp;
                    counter--;
                    continue;
                }
                else
                {

                    int temp = int.Parse(op);
                    sum += temp;
                    // Console.WriteLine(sum);
                    record[++counter] = temp;
                }
            }
            return sum;
        }

        public static string SmallestSubstringPattern(string input, string ptrn)
        {
            if (input.Length < ptrn.Length)
            {
                return "";
            }

            Dictionary<char, int> patternDict = new();

            foreach (var ch in ptrn)
            {
                if (patternDict.ContainsKey(ch))
                    patternDict[ch]++;
                else
                    patternDict.Add(ch, 1);
            }

            Dictionary<char, int> strDict = new();

            int start = 0, start_index = -1, min_len = int.MaxValue;
            int count = 0;

            for (int currentIndex = 0; currentIndex < input.Length; currentIndex++)
            {
                var currentCh = input[currentIndex];

                if (patternDict.ContainsKey(currentCh))
                {
                    if (strDict.ContainsKey(currentCh))
                        strDict[currentCh]++;
                    else
                        strDict.Add(currentCh, 1);

                    if (strDict[currentCh] <= patternDict[currentCh])
                        count++;
                }

                if (count == ptrn.Length)
                {
                    while (true && start < input.Length)
                    {
                        var startingChar = input[start];

                        if (patternDict.ContainsKey(startingChar))
                        {
                            strDict[startingChar]--;
                            if (patternDict[startingChar] > strDict[startingChar])
                            {
                                count--;
                                break;
                            }
                        }
                        start++;
                    }

                    var currentWindowLength = currentIndex - start + 1;
                    if (min_len > currentWindowLength)
                    {
                        min_len = currentWindowLength;
                        start_index = start;
                    }
                    start++;
                }
            }

            if (start_index == -1)
                return "";
            else
                return input.Substring(start_index, min_len);
        }
    }
}