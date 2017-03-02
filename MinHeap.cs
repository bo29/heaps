using System;

namespace Heaps
{
    class MinHeap
    {
        private int size;
        private int[] heap;
        public MinHeap()
        {
            heap = new int[6];//6 is used because the 0 index is not used and the heap can therefore have a size of 5 to start with
            size = 0;
        }
        public MinHeap(int number)
        {
            size = 1;
            heap = new int[6];
            heap[1] = number;
        }
        public MinHeap(int[] array)
        {
            heap = array;
            size = array.Length - 1;
            for (int i = size / 2; i >= 1; i--)
            {
                downHeap(size, i);
            }
        }
        private void swap(int i, int j)
        {
            if (i == j)
                return;
            int temp = heap[i];
            heap[i] = heap[j];
            heap[j] = temp;
        }
        private void upHeap()
        {
            int i = size;
            while (i > 1 && heap[i] < heap[i / 2])
            {
                swap(i, i / 2);
                i /= 2;
            }
        }
        private void downHeap(int n, int i)
        {
            int left = 2 * i;
            int right = left + 1;
            int min = i;
            if (left <= n && heap[min] > heap[left])
                min = left;
            if (right <= n && heap[min] > heap[right])
                min = right;
            if (min != i)
            {
                swap(i, min);
                downHeap(n, min);
            }
        }
        public void insert(int number)
        {
            if (size == 0)
            {
                heap[1] = number;
                size = 1;
            }
            else if(size+1==heap.Length){
                int[] temp = new int[2 * heap.Length];
                for (int i = 0; i < heap.Length; i++)
                    temp[i] = heap[i];
                heap = temp;
                size++;
                heap[size] = number;
                upHeap();
            }
            else
            {
                size++;
                heap[size] = number;
                upHeap();
            }
        }
        public int peek()
        {//check the root of the heap (smallest number)
            if (size == 0)
                throw new IndexOutOfRangeException("Empty heap");
            return heap[1];
        }
        public int pluck()
        {//the remove min function
            if (size == 0)
                throw new IndexOutOfRangeException("Empty heap");
            int min = heap[1];
            swap(1, size);
            size--;
            downHeap(size, 1);
            return min;
        }
        public int delete(int index)
        {//delete the specified index
            if (size == 0)
                throw new IndexOutOfRangeException("Empty heap");
            int min = heap[index];
            swap(index, size);
            size--;
            downHeap(size, index);
            return min;
        }
        public static int[] sort(int[] input)
        {//an implementation of HeapSort; puts array into increasing order
            MinHeap tempHeap = new MinHeap(input);
            int[] output = new int[tempHeap.Size()];
            for (int i = 0; i < output.Length; i++)
            {
                output[i] = tempHeap.pluck();
            }
            return output;
        }
        public void print()
        {
            for (int i = 1; i < size; i++)
            {
                Console.Write("{0}, ", heap[i]);
            }
            Console.WriteLine(heap[size]);
        }
        public int Size()
        {
            return size;
        }
    }
}