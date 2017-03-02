using System;

namespace Heaps
{
    class TestHeaps
    {
        static void Main(string[] args)
        {
            MinHeap heap = new MinHeap();
            heap.insert(7);
            heap.insert(5);
            heap.insert(8);
            heap.insert(0);
            heap.insert(3);
            Console.WriteLine(heap.peek());
            heap.print();
            int[] array = new int[] { 0, 20, 14, 9, 6, 4, 5, 1 };
            MinHeap heap2 = new MinHeap(array);
            MaxHeap max = new MaxHeap(array);
            max.print();
            max.delete(3);
            max.print();
            heap2.print();
            heap2.delete(3);
            heap2.print();
            int[] array3 = new int[] { 0, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            array3 = MinHeap.sort(array3);
            Console.WriteLine(string.Join(", ", array3));
            array3 = new int[] { 0, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            array3 = MaxHeap.sort(array3);
            Console.WriteLine(string.Join(", ", array3));
            Console.ReadLine();
        }
    }
}
