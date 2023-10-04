using DSA.LeetCode.ArraysAndString;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(ArraysAndStrings.IsPalindrome("racecar"));
        Console.WriteLine(ArraysAndStrings.CheckForTarget(new int[] { 10 }, 100));
        Console.WriteLine(string.Join(",", ArraysAndStrings.TwoSum(new int[] { 2, 7, 11, 15 }, 9)));
        Console.WriteLine(string.Join(",", ArraysAndStrings.TwoSum(new int[] { 3, 6, 7, 8, 9, 1, 6, 7, 8, 3 }, 6)));
    }
}