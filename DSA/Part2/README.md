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

## AVL Trees

Balanced Trees: If the difference between the height of the left and right subtress for every node is 0 or 1

Self Balancing tress

- AVL Tress (Adelson-velsky and landis)
- Red-black trees
- B-trees
- Splay Trees
- 2-3 Trees

Rotations

- LL
- RR
- LR
- RL

BST

- Average:O(log n)
- worst: O(n)

Self-balancing trees

## Heaps

A heap is a special type of tree with two perperties.

- First: Every level except, potentially the last level is completely filled and Levels are filled from the left to the right
  - This is called a complete tree: A complete binary tree is a special type of binary tree where all the levels of the tree are filled completely except the lowest level nodes which are filled from as left as possible.
- Second: Every node is greater than or equal with childrem
  - This is called Max Heap Property, where root node will have the highest value. In Min heaps root node will have the lowest value.

Applications

- Sorting (HeapSort)
- Graph algorithms (shortest path)
- Priority queues
- Finding the Kth smallest/largest value
- Height = h = log(n)
- Insertion (bubbling Up): O(log n) = O(h)
- Deletion: Only the root node can be deleted.
  - Delete the root node
  - Move last child to the root
  - Bubble down the root node to its correct location by swapping to its larger child
  - O(log n)
- Find Maximum
  - (Max heap): Return root. O(1)

leftChildIndex = `parentIndex * 2 + 1`
rightChildIndex = `parentIndex * 2 + 2`
parentIndex = (index-1)/2

## Tries Tree (Digital or Radix or Prefix)

Trees that can have several nodes

General Application is in auto-completion

- Each node could have 26 child nodes
- Root node will be null/empty char

Time complexity

- Search Operation : **O(L)**
- Adding a word : **O(L)**
- Removing a word : **O(L)**

where L is the length of the word we are searching for

Traversals

- Pre-Order : for Printing all nodes
- Post-Order : for delete a word

## Graphs

Graphs contains Nodes and egdes in which a node can connect to multiple nodes.

- Nodes are called vertices (V)
- Egdes are lines that connects two vertices
- Two Egdes connected by an edge is called adjacent (Neighbors)
- If Egdes have direction, we call that graph as directed graph, else undirected graph.
- Edges can have weight representing how strong a connection is.
- Application
  - Social media connections like facebook linkedin twitter
  - Shortest route or fastest path
- Implementation

  - Adjacency Matrix : problem space complexity = O(n^2). Suitable if you know the number of nodes you need and don't need to added for remove very often.

    - Add Operation = O(n^2)
    - Remove Node: O(n^2)
    - Adding edge: O(1)
    - Removing edge: O(1)
    - Query edge: O(1)
    - Find Neighbors: O(V)

  - Adjacency List: Better space complexity

    - Space for Dance graph (Every node is connected to every other node)

      - E = V(V-1)
      - E = V^2 - V
      - O(V+E) = O(v^2)

    - Add Operation = O(1)
    - Remove Node: O(V^2)
    - Adding edge: O(V)
    - Removing edge: O(V)
    - Query edge: O(V)
    - Find Neighbors: O(V)

    | Critaria       | Matrix | List Average | List Worst |
    | -------------- | ------ | ------------ | ---------- |
    | Space          | O(V^2) | O(V + E)     | O(V^2)     |
    | Add Edge       | O(1)   | O(K)         | O(V)       |
    | Remove Edge    | O(1)   | O(K)         | O(V)       |
    | Query Edge     | O(1)   | O(K)         | O(V)       |
    | Find Neighbors | O(V)   | O(K)         | O(V)       |
    | Add Node       | O(V^2) | O(1)         | O(1)       |
    | Remove Node    | O(V^2) | O(V^2)       | O(V^2)     |

  - If we are dealing with dense graph then use Matrix else use List. Generally List is better then Matrix

### Traversal

- DFS
  Start from a node and keep travering until you find the last node
- BFS
  - Start from a node and traverse its child first before moving forward
  - Implemented using a queue
- Can start traversal from anynode
  - Will reach all the nodes that are directly or indirectly connected to that node
