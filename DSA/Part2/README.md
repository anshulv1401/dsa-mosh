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
  - Topological sorting
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

### Topological Sorting

- To get correct order of operation on a task that are dependent on each other.
  - Scheduling Jobs
  - Build project with multiple dependencies
- Doesn't producee unique results
- Works on Graph without a cycle i.e, Directed Acyclic graph, DAG for short
- Impl
  - Start with DFS and reach to which is not dependent on any other operation
  - Use stack
  - Add the last node to the stack
  - Visit all the children
  - While backtracking add the node if all the children of the current node is already done in the stack.

### Cycle detection in directed graph

- Maintain 2 sets of notes
  - one to keep track of all the nodes in the graph
  - one to store the nodes that we are currently visiting. If we haven't visisted all its children we add it to visiting list.
  - one to store the nodes that we have visited. If we visit a node and all its childrens then we add it into visited list.
  - For cycle dectection with colors, simply rename the sets from visiting, visited to red, green etc.

## Undirected Graphs

- Weighted graphs

  - If edges have weight associated with it. we call it weighted graphs
    - Cost
    - Distance
    - Complexity
  - Common application is finding the shortest path between tweo nodes

- Dijkstra's shortest path algorithm: Example of a Greedy algorithum

  - Greedy alogrithum: Tries to find the optimal solution to a problem, by making optimal choices at each step.
  - Initialization of all nodes with distance "infinite"; initialization of the starting node with 0
  - Marking of the distance of the starting node as permanent, all other distances as temporarily.
  - Setting of starting node as active.
  - Calculation of the temporary distances of all neighbour nodes of the active node by summing up its distance with the weights of the edges.
  - If such a calculated distance of a node is smaller as the current one, update the distance and set the current node as antecessor. This step is also called update and is Dijkstra's central idea.
  - Setting of the node with the minimal temporary distance as active. Mark its distance as permanent.
  - Repeating of steps 4 to 7 until there aren't any nodes left with a permanent distance, which neighbours still have temporary distances.

```
  function Dijkstra(Graph, source):

      for each vertex v in Graph.Vertices:
          dist[v] ← INFINITY
          prev[v] ← UNDEFINED
          add v to Q
      dist[source] ← 0

      while Q is not empty:
          u ← vertex in Q with min dist[u]
          remove u from Q

          for each neighbor v of u still in Q:
              alt ← dist[u] + Graph.Edges(u, v)
              if alt < dist[v]:
                  dist[v] ← alt
                  prev[v] ← u
      return dist[], prev[]
```

- Spanning Tree: for N nodes we should have N-1 edges.
  - Spanning trees are without cycles
  - Prim's algorithm for finding the minimum spanning tree.
    - Extend the tree by adding the smallest connected edge
    - Example of greedy algorithm
  - Impl
    - Use a priority queue
    - Repeat until tree has all the nodes
    - Represent the tree using WeightedGraph
