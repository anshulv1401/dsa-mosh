#region Sorting

using DSA.Part3.Sorting;

var inputArray1 = new int[] { 50, 30, 20, 10, 100 };
SortingAlgo.BubbleSort(inputArray1);
Console.WriteLine("Bubble Sort" + string.Join(",", inputArray1));

var inputArray2 = new int[] { 100, 30, 20, 10, 50, 100 };
SortingAlgo.SelectionSort(inputArray2);
Console.WriteLine("Selection Sort" + string.Join(",", inputArray2));

var inputArray3 = new int[] { 100, 30, 20, 10, 50, 100 };
SortingAlgo.InsertionSort(inputArray3);
Console.WriteLine("Insertion Sort" + string.Join(",", inputArray3));

var inputArray4 = new int[] { 15, 6, 3, 1, 22, 10, 13 };
MergeSort.Sort(inputArray4);
Console.WriteLine("Merge Sort" + string.Join(",", inputArray4));

var inputArray5 = new int[] { 15, 6, 3, 1, 22, 10, 13 };
QuickSort.Sort(inputArray5);
Console.WriteLine("Quick Sort" + string.Join(",", inputArray5));

#endregion

