#region Sorting

using DSA.Part3.Sorting;

var inputArray1 = new int[] { 50, 30, 20, 10, 100 };
SortingAlgo.BubbleSort(inputArray1);
Console.WriteLine(string.Join(",", inputArray1));

var inputArray2 = new int[] { 100, 30, 20, 10, 50, 100 };
SortingAlgo.SelectionSort(inputArray2);
Console.WriteLine(string.Join(",", inputArray2));

var inputArray3 = new int[] { 100, 30, 20, 10, 50, 100 };
SortingAlgo.InsectionSort(inputArray3);
Console.WriteLine(string.Join(",", inputArray3));


var inputArray4 = new int[] { };
MergeSort.Sort(inputArray4);
Console.WriteLine(string.Join(",", inputArray4));

#endregion

