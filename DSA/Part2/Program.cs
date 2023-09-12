// See https://aka.ms/new-console-template for more information
//using DSA;
#region Binary Tree

// using DSA.Part1.BinaryTrees;

// var bst = new BinarySearchTree();

// bst.Insert(10);
// bst.Insert(40);
// bst.Insert(30);
// bst.Insert(20);
// bst.InOrderTraversal();
// Console.WriteLine();
// Console.WriteLine("Is 20 available? " + bst.Find(20));
// Console.WriteLine("Is 50 available? " + bst.Find(50));
// Console.WriteLine("height Of the Tree " + bst.Height());
// Console.WriteLine("Min Value in the Tree " + bst.FindMin());
// Console.WriteLine("Max Value in the Tree " + bst.FindMax());

// var bt1 = new BinaryTree();

// bt1.Insert(10);
// bt1.Insert(40);
// bt1.Insert(30);
// bt1.Insert(35);
// bt1.Insert(20);
// bt1.Insert(10);

// var bt2 = new BinaryTree();

// bt2.Insert(40);
// bt2.Insert(30);
// bt2.Insert(20);
// bt2.Insert(10);

// Console.WriteLine();
// Console.WriteLine("Is 20 available? " + bt1.Find(20));
// Console.WriteLine("Is 50 available? " + bt1.Find(50));
// Console.WriteLine("height Of the Tree " + bt1.Height());
// Console.WriteLine("Min Value in the Tree " + bt1.FindMin());
// Console.WriteLine("Is BT1 equals BT2 " + bt1.TreeEquals(bt2.root));
// Console.WriteLine("Is BST " + bt1.IsBST());
// Console.WriteLine("Is BST " + bt2.IsBST());

// var bt3 = new BinaryTree();

// bt3.Insert(7);
// bt3.Insert(4);
// bt3.Insert(9);
// bt3.Insert(1);
// bt3.Insert(6);
// bt3.Insert(8);
// bt3.Insert(10);
// bt3.Insert(15);
// bt3.Insert(13);
// bt3.Insert(14);
// bt3.Insert(11);

// var result = bt3.NodesAtKDistance(2);
// Console.WriteLine(string.Join("->", result));

// bt3.LevelOrderTraversal();
// bt3.LevelOrderTraversal2();
// Console.WriteLine("size: " + bt3.Size());
// Console.WriteLine("Leaves count: " + bt3.CountLeaves());
// Console.WriteLine("Contains 1: " + bt3.Contains(1));
// Console.WriteLine("Contains 1111: " + bt3.Contains(1111));

// Console.WriteLine("AreSibling: " + bt3.AreSibling(1, 6));
// Console.WriteLine("Ancestors of 10:" + string.Join("-->", bt3.GetAncestors(10)));
// Console.WriteLine("Ancestors of 6:" + string.Join("-->", bt3.GetAncestors(6)));
// Console.WriteLine("Ancestors of 11:" + string.Join("-->", bt3.GetAncestors(11)));
// Console.WriteLine("Ancestors of 13:" + string.Join("-->", bt3.GetAncestors(13)));
// var bt4 = new BinaryTree();
// // Console.WriteLine("Ancestors of 13 in empty tree:" + string.Join("-->", bt4.GetAncestors(13)));
// bt4.Insert(13);
// Console.WriteLine("Ancestors of 13 with only root node:" + string.Join("-->", bt4.GetAncestors(13)));

#endregion

#region AVLTrees

using DSA.Part1.AVLTrees;

var aVLTree = new AVLTree();
aVLTree.Insert(7);
aVLTree.Insert(4);
aVLTree.Insert(9);
aVLTree.Insert(1);
aVLTree.Insert(6);
aVLTree.Insert(8);
aVLTree.Insert(10);
aVLTree.Insert(14);
aVLTree.Insert(15);
aVLTree.Insert(13);
aVLTree.LevelOrderTraversal();

#endregion