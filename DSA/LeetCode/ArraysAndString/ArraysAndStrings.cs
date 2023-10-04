namespace DSA.LeetCode.ArraysAndString
{
    public class ArraysAndStrings
    {
        public static bool IsPalindrome(string s)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                if (s[left] != s[right])
                    return false;
                left++;
                right--;
            }
            return true;
        }

        //nums is sorted
        //Given a sorted array of unique integers and a target integer, return true if there exists a pair of numbers that sum to target, false otherwise.
        public static bool CheckForTarget(int[] nums, int target)
        {

            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                int currentSum = nums[left] + nums[right];
                if (currentSum == target)
                    return true;
                if (currentSum < target)
                    left++;
                else
                    right--;
            }

            return false;
        }

        //nums is unsorted
        //https://leetcode.com/problems/two-sum/
        //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        public static int[] TwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var diff = target - nums[i];
                if (dict.ContainsKey(diff) && dict[diff] != i)
                {
                    return new int[] { dict[diff], i };
                }
                dict.TryAdd(nums[i], i);
            }
            return Array.Empty<int>();
        }
    }
}