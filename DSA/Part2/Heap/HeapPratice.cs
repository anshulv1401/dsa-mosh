using System.Net.Sockets;

namespace DSA.Part2.Heap
{

    public class HeapPratice
    {
        public static void SortArrayUsingHeap(int[] numbers)
        {
            var heap = new HeapTree(numbers.Length);
            foreach (var num in numbers)
                heap.Insert(num);

            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = heap.Remove();

            Console.WriteLine("asc: " + string.Join(",", numbers));

            numbers = new int[] { 5, 3, 10, 1, 4, 2 };
            foreach (var num in numbers)
                heap.Insert(num);

            for (int i = numbers.Length - 1; i >= 0; i--)
                numbers[i] = heap.Remove();

            Console.WriteLine("dsc: " + string.Join(",", numbers));
        }

        //Find Kth Largest Item

        public static int FindKthLargestItemInArray(int[] array, int k)
        {
            var heap = new HeapTree(array.Length);

            foreach (var item in array)
                heap.Insert(item);

            for (int i = 0; i < k - 1; i++)
                heap.Remove();

            return heap.Max();
        }

        //Converting a array into heap array IN-PLACE recursively
        public static void HeapifyRecursively(int[] inputArray)
        {
            for (int index = LastParentIndex(inputArray.Length); index >= 0; index--)
            {
                HeapifyRecursively(inputArray, index);
            }
        }


        private static void HeapifyRecursively(int[] inputArray, int rootIndex)
        {
            int greaterIndex = rootIndex;

            int leftIndex = LeftChildIndex(rootIndex);
            int rightIndex = RightChildIndex(rootIndex);
            if (leftIndex < inputArray.Length && inputArray[leftIndex] > inputArray[greaterIndex])
                greaterIndex = leftIndex;

            if (rightIndex < inputArray.Length && inputArray[rightIndex] > inputArray[greaterIndex])
                greaterIndex = rightIndex;

            if (rootIndex == greaterIndex)
                return;

            Swap(inputArray, rootIndex, greaterIndex);
            HeapifyRecursively(inputArray, greaterIndex);
        }

        //Converting a array into heap array IN-PLACE
        public static void Heapify(int[] inputArray)
        {
            for (int index = LastParentIndex(inputArray.Length); index >= 0; index--)
            {
                BubbleDown(inputArray, index);
            }
        }

        public static void BubbleDown(int[] array, int rootIndex)
        {
            if (IsValidParent(array, rootIndex))
                return;

            int leftIndex = LeftChildIndex(rootIndex);
            int rightIndex = RightChildIndex(rootIndex);
            int greaterChild = array[leftIndex] < array[rightIndex] ? rightIndex : leftIndex;
            Swap(array, rootIndex, greaterChild);
            BubbleDown(array, greaterChild);
        }

        public static void Swap(int[] array, int index1, int index2)
        {
            (array[index1], array[index2]) = (array[index2], array[index1]);
        }

        private static bool IsValidParent(int[] array, int indexOfParent)
        {
            var leftChildIndex = LeftChildIndex(indexOfParent);
            var rightChildIndex = RightChildIndex(indexOfParent);
            if (leftChildIndex >= array.Length)
                return true;

            if (rightChildIndex >= array.Length)
                return array[indexOfParent] >= array[leftChildIndex];

            return array[indexOfParent] >= array[leftChildIndex] && array[indexOfParent] >= array[rightChildIndex];
        }

        private static int LeftChildIndex(int indexOfParent)
        {
            return (indexOfParent * 2) + 1;
        }

        private static int RightChildIndex(int indexOfParent)
        {
            return (indexOfParent * 2) + 2;
        }

        private static int ParentIndex(int childIndex)
        {
            return (childIndex - 1) / 2;
        }

        private static int LastParentIndex(int arraySize)
        {
            return (arraySize / 2) - 1;
        }
    }
}