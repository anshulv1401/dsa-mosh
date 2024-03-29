# Mosh Course The Ultimate Data Structures and Algorithms Part1

## Big O

Big O notation is a mathematical notation that descirbes the limiting behavior of a function when the argument tends towards a particular value or infinity.

## Dynmaic arrays

`List<string>`

Complixity

- Lookup by index O(1)
- Lookup by value O(n);
- Insert O(n);
- Delete O(n);

## Linkedlist

- Second Most unsed data structures
- Grow and shrink automatically
- Take a bit more memory

Complexities

- Lookup
  - By Index O(n)
  - By Value O(n)
- Insert
  - Beginneing/End O(1)
  - Middle O(n)
- Delete
  - Beginning O(1)
  - Middle O(n)
  - End o(n) in singly/O(1) in doubly

## Stack (LIFO)

- Implement the undo feature
- Build compliers (eg sysntax checking)
- Evaluate expressions `(eg 1 + 2*3)`
- Build navigation (eg forward/back)

Complixity all O(1)

- push
- pop
- peek
- isEmpty

## Queues (FIFO)

- Printers
- Operating systems
- Web servers
- Live support systems

Complixity all O(1)

- enqueue
- dequeue
- peek
- isEmpty
- isFull

## Hash Tables (FIFO)

- To Store key/value pairs
- Insert, remove, loolup run in O(1)
- Spell checkers
- Dictionaries
- Compilers
- Code editors

Impl

- Java - HashMap
- Javascript - Object
- Python - Dictionary
- C# - Dictionary

Operation O(1)

- Insert
- Lookup
- Delete

Hash function is a function that gets a value and maps it to a different kind of value, which we call a hash value, a hash code, digest or just hash

Collisions: if a hash function return same hash for different key, then it is called collision.

Solution

- Chaining: Using linkedlist in place of value itself.
- Open addressing: Finding a new address for the 2nd value
  - Linear Probing: hash(key) + i % table_size. Keep going to the next index until we find an empty slot. Problem is clusters
  - Quadratic Probing: hash(key) + i^2 % table_size. Less clusters, but could end up in infinite loop even if you have empty slots.
  - Double Hashing: hash(key) + i \* hash2 % table_size. We use separate independent hash function to calculate the number of steps.
