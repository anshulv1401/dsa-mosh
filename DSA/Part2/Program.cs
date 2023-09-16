#region Binary Tree

//using DSA;
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

// using DSA.Part2.AVLTrees;
// using DSA.Part2.BinaryTrees;

// var aVLTree = new AVLTree();
// aVLTree.Insert(7);
// aVLTree.Insert(4);
// aVLTree.Insert(9);
// aVLTree.Insert(1);
// aVLTree.Insert(6);
// aVLTree.Insert(8);
// aVLTree.Insert(10);
// aVLTree.Insert(14);
// aVLTree.Insert(15);
// aVLTree.Insert(13);
// aVLTree.Insert(10);
// aVLTree.Insert(20);
// aVLTree.Insert(30);
// // aVLTree.Insert(40);
// aVLTree.LevelOrderTraversal();

// var btBalanced = new BinaryTree();
// btBalanced.Insert(14);
// btBalanced.Insert(6);
// btBalanced.Insert(22);
// btBalanced.Insert(2);
// btBalanced.Insert(10);
// btBalanced.Insert(18);
// btBalanced.Insert(26);
// btBalanced.Insert(0);
// btBalanced.Insert(4);
// btBalanced.Insert(8);
// btBalanced.Insert(12);
// btBalanced.Insert(16);
// btBalanced.Insert(20);
// btBalanced.Insert(24);
// // btBalanced.Insert(3);
// btBalanced.Insert(28);
// btBalanced.LevelOrderTraversal2();

// Console.WriteLine("IsBalanced: " + btBalanced.IsBalanced());
// Console.WriteLine("IsBalanced2: " + btBalanced.IsBalanced2());
// Console.WriteLine("IsPerfect: " + btBalanced.IsPerfect());
// Console.WriteLine("IsPerfect2: " + btBalanced.IsPerfect2());

#endregion

#region Heap

using DSA.Part2.Heap;

var heap = new HeapTree(10);

heap.Insert(15);
heap.Insert(10);
heap.Insert(3);
heap.Insert(8);
heap.Insert(12);
heap.Insert(9);
heap.Insert(4);
heap.Insert(1);
heap.PrintTree();
heap.Insert(24);
heap.PrintTree();
Console.WriteLine(heap.Remove());
heap.PrintTree();

int[] numbers1 = new int[] { 5, 3, 10, 1, 4, 2 };
HeapPratice.SortArrayUsingHeap(numbers1);

int[] numbers2 = new int[] { 5, 3, 8, 1, 4, 2, 10, 20, 30, 40, 80, 70, 200, 100, 90 };
Console.WriteLine("Before heapify recursively: " + string.Join(",", numbers2));
HeapPratice.HeapifyRecursively(numbers2);
Console.WriteLine("After heapify recursively: " + string.Join(",", numbers2));

int[] numbers3 = new int[] { 5, 3, 8, 1, 4, 2, 10, 20, 30, 40, 80, 70, 200, 100, 90 };
Console.WriteLine("5th largest item: " + HeapPratice.FindKthLargestItemInArray(numbers3, 5));

#endregion