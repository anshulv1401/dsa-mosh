// See https://aka.ms/new-console-template for more information
using DSA;

var customArray = new CustomArray(3);

customArray.Insert(10);
customArray.Insert(20);
customArray.Insert(30);
customArray.Insert(40);
customArray.RemoveAt(1);
customArray.Print();
Console.WriteLine(customArray.IndexOf(30));
Console.WriteLine(customArray.IndexOf(100));