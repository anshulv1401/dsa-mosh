# Mosh Course The Ultimate Data Structures and Algorithms Part3

## Sorting Algorithms

| Sorting algo   | Best       | Worst      | comment               |
| -------------- | ---------- | ---------- | --------------------- |
| Bubble sort    | O(n)       | O(n^2)     |                       |
| Selection Sort | O(n^2)     | O(n^2)     |                       |
| Insertion Sort | O(n)       | O(n^2)     |                       |
| Merge Sort     | O(n log n) | O(n log n) | Requires extra space  |
| Quick Sort     | O(n log n) | O(n^2)     | In place alog         |
| Counting Sort  | O(n)       | O(n)       | Time-memory trade off |
| Bucket Sort    | O(n)       | O(n^2)     | Space comp : O(n +k)  |

- Counting Sort use when
  - Allocating extra space is not an issue
  - Values are positve integers
  - Most of the values in the range are present

## Searching Algorithms

| Searching algo     | Best            | Worst           | comment                       |
| ------------------ | --------------- | --------------- | ----------------------------- |
| Linear Search      | O(1)            | O(n)            |                               |
| Binary Search      | O(log n)        | O(log n)        | Space O(n)/O(1)               |
| Ternary Search     | O(log n) base 3 | O(log n) base 3 | performs bad in worst case    |
| Jump Search        | O(root n)       | O(root n)       | Ideal block size is Root of n |
| Exponential Search |                 |                 |                               |

- Ternary Search
- Jump search,
