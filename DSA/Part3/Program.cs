#region Sorting

// using DSA.Part3.Sorting;

// var inputArray1 = new int[] { 50, 30, 20, 10, 100 };
// SortingAlgo.BubbleSort(inputArray1);
// Console.WriteLine("Bubble Sort " + string.Join(",", inputArray1));

// var inputArray2 = new int[] { 100, 30, 20, 10, 50, 100 };
// SortingAlgo.SelectionSort(inputArray2);
// Console.WriteLine("Selection Sort " + string.Join(",", inputArray2));

// var inputArray3 = new int[] { 100, 30, 20, 10, 50, 100 };
// SortingAlgo.InsertionSort(inputArray3);
// Console.WriteLine("Insertion Sort " + string.Join(",", inputArray3));

// var inputArray4 = new int[] { 15, 6, 3, 1, 22, 10, 13 };
// MergeSort.Sort(inputArray4);
// Console.WriteLine("Merge Sort " + string.Join(",", inputArray4));

// var inputArray5 = new int[] { 15, 6, 3, 1, 22, 10, 13 };
// QuickSort.Sort(inputArray5);
// Console.WriteLine("Quick Sort " + string.Join(",", inputArray5));

// var inputArray6 = new int[] { 15, 6, 3, 1, 22, 10, 13 };
// CountingSort.Sort(inputArray6, 22);
// Console.WriteLine("Counting Sort " + string.Join(",", inputArray6));

// var inputArray7 = new int[] { 15, 6, 3, 22, 10, 13 };
// CountingSort.Sort(inputArray7, 3, 22);
// Console.WriteLine("Counting improved Sort " + string.Join(",", inputArray7));

// var inputArray8 = new int[] { 15, 6, 3, 22, 10, 13 };
// // var inputArray8 = new int[] { 7, 1, 3, 5, 3 };
// BucketSort.Sort(inputArray8, 9);
// Console.WriteLine("Bucket Sort " + string.Join(",", inputArray8));

#endregion

#region Searching

// using DSA.Part3.Searching;
// using DSA.Part3.Sorting;

// var inputArray9 = new int[] { -1, 15, 6, 3, 22, 10, 13 };
// Console.WriteLine("Linear Search " + LinearSearch.Search(inputArray9, 6));

// QuickSort.Sort(inputArray9);
// Console.WriteLine("Binary Search " + BinarySearch.Search(inputArray9, 6));
// Console.WriteLine("Binary Search " + BinarySearch.SearchIt(inputArray9, 6));

// Console.WriteLine("Ternary Search " + TernarySearch.Search(inputArray9, -1));

// Console.WriteLine("Jump Search " + JumpSearch.Search(inputArray9, 9));
// Console.WriteLine("Exponential Search " + JumpSearch.Search(inputArray9, -1));

#endregion

#region StringManipulation

// using DSA.Part3.StringManipulation;

// Console.WriteLine("Number of vowels " + Exercises.FindNumberOfVowels("asf asdf fdsaf fd ||| f {{}} "));
// Console.WriteLine("Reverse a string " + Exercises.ReverseAString("Hello my name is Anshul!"));
// Console.WriteLine("Reverse Words " + Exercises.ReverseWords("   Hello! my name is Anshul    "));
// Console.WriteLine("IsRotation " + Exercises.IsRotation("ABCD", "DABC"));
// Console.WriteLine("IsRotation " + Exercises.IsRotation2("AB CD", "DABC "));
// Console.WriteLine("Remove Duplicates " + Exercises.RemoveDuplicateCharacters("Helloooffff||11"));
// Console.WriteLine("Most Repeated Char " + Exercises.FindMostRepeatedChar("Hellooooffff||11"));
// Console.WriteLine("Most Repeated Char2 " + Exercises.FindMostRepeatedChar2("Helloooofffff||11"));
// Console.WriteLine("Capitalize " + Exercises.Capitalize("  trees are   beautiful   "));
// Console.WriteLine("Are Anagrams " + Exercises.AreAnagram("trees are beautifulff", "trees are beautifulgg"));
// Console.WriteLine("Are Anagrams2 " + Exercises.AreAnagram2("trees are beautiful", "trees are beautiful"));
// Console.WriteLine("Is Palindrome " + Exercises.IsPalindrome("CAA   AAC"));


#endregion

using DSA.Part3;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] ops = new string[] { "5", "2", "D", "C", "+" };

        int output = PracticeTest.CalPoints(ops);

        Console.WriteLine(output.ToString());


        Console.WriteLine(PracticeTest.SmallestSubstringPattern("this is a test string", "tist")); ;
        Console.WriteLine(PracticeTest.SmallestSubstringPattern("geeksforgeeks", "ksfor"));
    }
}