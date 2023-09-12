# Mosh Course The Ultimate Data Structures and Algorithms Part2

## BinaryTrees

- Represent hierarchical data
- Databases
- Autocompletion
- Compilers
- Compression (JPEG, MP3)

Binary Tree: A Tree where all its nodes can have atmost 2 childers

- Traversals
  - Breadth first
    - level-order
  - Depth first
    - Pre-order
    - In-order
    - Post-order

Binary Search Tree: `left < Node < Right`

- Search O(log n)
- Insertion O(log n)
- Deletion O(log n)

Better then array and linkedlist generally

- Depth = Number of edges
- Height = Longest path to the leef = 1 + max(height(L), height(R)) (could use post order traversal to calculate height of the tree)
- Note :
  - Height of leafs is zero
  - Height of a tree is the height of its root node
  - Depth of root node is zero
  - Depth of any node is the number of edges from root to itself
