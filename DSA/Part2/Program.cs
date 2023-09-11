// See https://aka.ms/new-console-template for more information
//using DSA;
#region Binary Tree

using DSA.Part1.BinaryTrees;

var bst = new BinarySearchTree();

bst.Insert(10);
bst.Insert(40);
bst.Insert(30);
bst.Insert(20);
bst.InOrderTraversal();
Console.WriteLine();
Console.WriteLine("Is 20 available? " + bst.Find(20));
Console.WriteLine("Is 50 available? " + bst.Find(50));
Console.WriteLine("height Of the Tree " + bst.Height());
Console.WriteLine("Min Value in the Tree " + bst.FindMin());

var bt = new BinaryTree();

bt.Insert(10);
bt.Insert(40);
bt.Insert(30);
bt.Insert(20);
bt.InOrderTraversal();
Console.WriteLine();
Console.WriteLine("Is 20 available? " + bt.Find(20));
Console.WriteLine("Is 50 available? " + bt.Find(50));
Console.WriteLine("height Of the Tree " + bt.Height());
Console.WriteLine("Min Value in the Tree " + bt.FindMin());

#endregion