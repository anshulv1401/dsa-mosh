﻿// See https://aka.ms/new-console-template for more information
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

var bt1 = new BinaryTree();

bt1.Insert(10);
bt1.Insert(40);
bt1.Insert(30);
bt1.Insert(20);

var bt2 = new BinaryTree();

bt2.Insert(40);
bt2.Insert(30);
bt2.Insert(20);
bt2.Insert(10);

Console.WriteLine();
Console.WriteLine("Is 20 available? " + bt1.Find(20));
Console.WriteLine("Is 50 available? " + bt1.Find(50));
Console.WriteLine("height Of the Tree " + bt1.Height());
Console.WriteLine("Min Value in the Tree " + bt1.FindMin());
Console.WriteLine("Is BST equals BT " + bt1.TreeEquals(null));

#endregion