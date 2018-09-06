using System;
namespace Heaps
{
    public class MaxHeap
    {
        private long[] _array;
        public int HeapSize { get; private set; }
        public MaxHeap(long[] array)
        {
            _array = array;
        }

        public int Parent(int i) { return (i - 1) / 2; }
        public int Left(int i) { return 2 * i + 1; }
        public int Right(int i) { return 2 * i + 2; }

        public void MaxHeapify(int i) {
            var l = Left(i);
            var r = Right(i);
            int largest = 0;

            if (l < HeapSize && _array[l] > _array[i])
                largest = l;
            else
                largest = i;
            if (r < HeapSize && _array[r] > _array[i]) 
                largest = r;
            if (largest != i) 
            {
                Swap(ref _array[i], ref _array[largest]);
                MaxHeapify(largest);
            }
        }

        public long[] BuildHeap() {
            HeapSize = _array.Length;
            for (int i = (_array.Length / 2) - 1; i >= 0; i--)
                MaxHeapify(i);

            return _array;
        }

        public long[] HeapSort()
        {
            BuildHeap();
            for (int i = _array.Length - 1; i >= 1; i--)
            {
                Swap(ref _array[i], ref _array[0]);
                --HeapSize;
                MaxHeapify(0);
            }

            return _array;
        }

        private void Swap(ref long a, ref long b)
        {
            var temp = a;
            a = b;
            b = temp;
        }
    }
}
