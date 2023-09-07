// See https://aka.ms/new-console-template for more information
//using DSA;
using DSA.LinkedList;
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



CustomStackLinkedList CustomStackLinkedList = new();

CustomStackLinkedList.Push(10);
CustomStackLinkedList.Push(20);
CustomStackLinkedList.Push(30);
CustomStackLinkedList.Push(40);
CustomStackLinkedList.Push(50);
CustomStackLinkedList.Push(60);

Console.WriteLine(CustomStackLinkedList.ToString());

Console.WriteLine(CustomStackLinkedList.Pop());
Console.WriteLine(CustomStackLinkedList.Pop());
Console.WriteLine(CustomStackLinkedList.Pop());
Console.WriteLine(CustomStackLinkedList.Pop());
Console.WriteLine(CustomStackLinkedList.Pop());

Console.WriteLine(CustomStackLinkedList.Peek());
Console.WriteLine(CustomStackLinkedList.IsEmpty());
Console.WriteLine(CustomStackLinkedList.Pop());
Console.WriteLine(CustomStackLinkedList.IsEmpty());


#endregion