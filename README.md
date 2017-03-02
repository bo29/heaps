# heaps

This is a small project I did to demonstrate C#. I created the MinHeap object based on what was covered in my advanced data structures and algorithm design class. I also created a MaxHeap object for extra compatibility.

Both classes have their own implementation of HeapSort, which is well-known to be a reliable sorting algorithm but not always the fastest. MinHeap sorts the array in increasing order and MaxHeap sorts in decreasing order.

Heaps are a data structure based off the binary tree that satisfies the following property: that every node is larger than the parent and that every subtree is also a heap. They are useful in situations where it is necessary to always have the smallest element easily accessible, which is common in practical use. Additionally, heaps can get the next smallest rather quickly using their deleteMin function, which I named "pluck" in my implementations. This description specifically describes MinHeaps. A MaxHeap is the same, except the maximum number is the root and the parent of every node is instead larger.
