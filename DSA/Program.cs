// See https://aka.ms/new-console-template for more information
using DSA;

var customArray = new CustomArray(3);

customArray.Insert(10);
customArray.Insert(20);
customArray.Insert(30);
customArray.Insert(40);
customArray.Insert(-10000000);
customArray.Insert(1000000);
customArray.Insert(56);
customArray.RemoveAt(1);
Console.WriteLine("Max is " + customArray.Max());
customArray.Print();

var intersect = customArray.Intersect(new int[] { 10, 10, 10, 10, 10, 10, 20, 40, 30 });

Console.WriteLine("Intersect is:");
foreach (var item in intersect)
{
    Console.Write(item + " ");
}
Console.WriteLine();
// customArray.ReverseArray();
// Console.WriteLine("Reverse is:");
// customArray.Print();

customArray.InsertAt(1, 20);
Console.WriteLine("After inserting 20 at index 1:");
customArray.Print();