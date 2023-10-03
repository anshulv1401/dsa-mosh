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
    }
}