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

var bt1 = new BinaryTree();

bt1.Insert(10);
bt1.Insert(40);
bt1.Insert(30);
bt1.Insert(35);
bt1.Insert(20);
bt1.Insert(10);

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
Console.WriteLine("Is BT1 equals BT2 " + bt1.TreeEquals(bt2.root));
Console.WriteLine("Is BST " + bt1.IsBST());
Console.WriteLine("Is BST " + bt2.IsBST());


var bt3 = new BinaryTree();

bt3.Insert(7);
bt3.Insert(4);
bt3.Insert(9);
bt3.Insert(1);
bt3.Insert(6);
bt3.Insert(8);
bt3.Insert(10);

var result = bt3.NodesAtKDistance(2);
Console.WriteLine(string.Join("->", result));

#endregion