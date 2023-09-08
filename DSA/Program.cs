// See https://aka.ms/new-console-template for more information
//using DSA;
using DSA.LinkedList;
using DSA.Queues;
using DSA.Stacks;

#region Arrays

// var customArray = new CustomArray(3);

// customArray.Insert(10);
// customArray.Insert(20);
// customArray.Insert(30);
// customArray.Insert(40);
// customArray.Insert(-10000000);
// customArray.Insert(1000000);
// customArray.Insert(56);
// customArray.RemoveAt(1);
// Console.WriteLine("Max is " + customArray.Max());
// customArray.Print();

// var intersect = customArray.Intersect(new int[] { 10, 10, 10, 10, 10, 10, 20, 40, 30 });

// Console.WriteLine("Intersect is:");
// foreach (var item in intersect)
// {
//     Console.Write(item + " ");
// }
// Console.WriteLine();
// // customArray.ReverseArray();
// // Console.WriteLine("Reverse is:");
// // customArray.Print();

// customArray.InsertAt(1, 20);
// Console.WriteLine("After inserting 20 at index 1:");
// customArray.Print();

#endregion

#region linkedlist

// var customll = new CustomLinkedList<int>();
// customll.AddLast(50);
// customll.AddLast(60);
// customll.AddLast(70);

// customll.AddFirst(40);
// customll.AddFirst(30);
// customll.AddFirst(20);

// Console.WriteLine(customll.ToString());
// customll.DeleteFirst();
// Console.WriteLine(customll.ToString());
// customll.DeleteLast();
// Console.WriteLine(customll.ToString());
// Console.WriteLine("Contains 50: " + customll.Constains(50));
// Console.WriteLine("Contains 9000: " + customll.Constains(9000));
// Console.WriteLine("Index of 50: " + customll.IndexOf(50));
// Console.WriteLine("Index of 9000: " + customll.IndexOf(9000));
// Console.WriteLine("Size " + customll.Lenght());


// var customll2 = new CustomLinkedList<int>();

// customll2.AddLast(50);
// customll2.AddLast(60);
// customll2.AddLast(70);
// customll2.AddFirst(40);
// customll2.AddFirst(30);
// customll2.AddFirst(20);


// Console.WriteLine(customll2.ToString());
// customll2.Reverse();
// Console.WriteLine(customll2.ToString());


// Console.WriteLine(customll2.FindKthNodeFromEnd(1));
// Console.WriteLine(customll2.FindKthNodeFromEnd(6));
// Console.WriteLine(customll2.FindKthNodeFromEnd(0));

// Console.WriteLine("FindMiddle: " + customll2.FindMiddle());
// customll2.CreateLoop();
// Console.WriteLine("Contains loop?: " + customll2.CheckForLoop());

#endregion

#region stack

// StackPractice stackPractice = new();

// Console.WriteLine(stackPractice.ReverseAString("Hello!"));
// Console.WriteLine(stackPractice.IsBalancedExpression("((([[[<<({{}})>>]]])))"));

// CustomStackArray customStackArray = new();

// customStackArray.Push(10);
// customStackArray.Push(20);
// customStackArray.Push(30);
// customStackArray.Push(40);
// customStackArray.Push(50);
// customStackArray.Push(60);

// Console.WriteLine(customStackArray.ToString());

// Console.WriteLine(customStackArray.Pop());
// Console.WriteLine(customStackArray.Pop());
// Console.WriteLine(customStackArray.Pop());
// Console.WriteLine(customStackArray.Pop());
// Console.WriteLine(customStackArray.Pop());

// Console.WriteLine(customStackArray.Peek());
// Console.WriteLine(customStackArray.IsEmpty());
// Console.WriteLine(customStackArray.Pop());
// Console.WriteLine(customStackArray.IsEmpty());



// CustomStackLinkedList CustomStackLinkedList = new();

// CustomStackLinkedList.Push(10);
// CustomStackLinkedList.Push(20);
// CustomStackLinkedList.Push(30);
// CustomStackLinkedList.Push(40);
// CustomStackLinkedList.Push(50);
// CustomStackLinkedList.Push(60);

// Console.WriteLine(CustomStackLinkedList.ToString());

// Console.WriteLine(CustomStackLinkedList.Pop());
// Console.WriteLine(CustomStackLinkedList.Pop());
// Console.WriteLine(CustomStackLinkedList.Pop());
// Console.WriteLine(CustomStackLinkedList.Pop());
// Console.WriteLine(CustomStackLinkedList.Pop());

// Console.WriteLine(CustomStackLinkedList.Peek());
// Console.WriteLine(CustomStackLinkedList.IsEmpty());
// Console.WriteLine(CustomStackLinkedList.Pop());
// Console.WriteLine(CustomStackLinkedList.IsEmpty());


// Custom2StackWith1Array custom2StackWith1Array = new();

// custom2StackWith1Array.Push1(10);
// custom2StackWith1Array.Push1(20);
// custom2StackWith1Array.Push1(30);
// custom2StackWith1Array.Push1(40);
// custom2StackWith1Array.Push1(50);

// custom2StackWith1Array.Push2(60);
// custom2StackWith1Array.Push2(70);
// custom2StackWith1Array.Push2(80);
// custom2StackWith1Array.Push2(90);
// custom2StackWith1Array.Push2(100);

// Console.WriteLine(custom2StackWith1Array.ToString());

// Console.WriteLine(custom2StackWith1Array.IsFull1());
// Console.WriteLine(custom2StackWith1Array.IsFull2());

// Console.WriteLine(custom2StackWith1Array.Pop1());
// Console.WriteLine(custom2StackWith1Array.Pop1());
// Console.WriteLine(custom2StackWith1Array.Pop1());
// Console.WriteLine(custom2StackWith1Array.Pop1());

// Console.WriteLine(custom2StackWith1Array.Pop2());
// Console.WriteLine(custom2StackWith1Array.Pop2());
// Console.WriteLine(custom2StackWith1Array.Pop2());
// Console.WriteLine(custom2StackWith1Array.Pop2());

// Console.WriteLine(custom2StackWith1Array.Peek1());
// Console.WriteLine(custom2StackWith1Array.Peek2());
// Console.WriteLine(custom2StackWith1Array.IsEmpty1());
// Console.WriteLine(custom2StackWith1Array.IsEmpty2());


// CustomMinStack customMinStack = new();

// customMinStack.Push(5);
// customMinStack.Push(2);
// customMinStack.Push(10);
// customMinStack.Push(1);
// Console.WriteLine(customMinStack.ToString());

// Console.WriteLine(customMinStack.Min());
// customMinStack.Pop();
// customMinStack.Pop();
// customMinStack.Pop();
// Console.WriteLine(customMinStack.Min());

#endregion

#region stack

// QueuesPratice queuesPratice = new();

// Queue<int> queue = new();
// queue.Enqueue(10);
// queue.Enqueue(20);
// queue.Enqueue(30);
// queue.Enqueue(40);

// Console.WriteLine(queuesPratice.ReverseQueue(queue));


// CustomQueueArray customQueueArray = new();
// customQueueArray.Enqueue(10);
// customQueueArray.Enqueue(20);
// customQueueArray.Enqueue(30);
// customQueueArray.Enqueue(40);
// customQueueArray.Enqueue(50);

// customQueueArray.Enqueue(60);
// customQueueArray.Enqueue(70);
// customQueueArray.Enqueue(80);
// customQueueArray.Enqueue(90);
// customQueueArray.Enqueue(100);

// Console.WriteLine(customQueueArray.ToString());
// Console.WriteLine(customQueueArray.IsFull());
// Console.WriteLine(customQueueArray.IsEmpty());

CustomQueueWith2Stack customQueueWith2Stack = new();
customQueueWith2Stack.Enqueue(10);
customQueueWith2Stack.Enqueue(20);
customQueueWith2Stack.Enqueue(30);
customQueueWith2Stack.Enqueue(40);
customQueueWith2Stack.Enqueue(50);
customQueueWith2Stack.Enqueue(60);
Console.WriteLine(customQueueWith2Stack.ToString());
Console.WriteLine(customQueueWith2Stack.Dequeue());
Console.WriteLine(customQueueWith2Stack.Dequeue());
Console.WriteLine(customQueueWith2Stack.Dequeue());
Console.WriteLine(customQueueWith2Stack.Dequeue());
Console.WriteLine(customQueueWith2Stack.Dequeue());
Console.WriteLine(customQueueWith2Stack.Dequeue());

#endregion