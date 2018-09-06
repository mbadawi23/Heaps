using System;

namespace Heaps
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            long[] a = { 1, 8, 4, 14, 3, 9, 7, 2, 10, 16};
            PrintArray(a);

            var h = new MaxHeap(a);
            PrintArray(h.BuildHeap(), "Heap");
            var aSorted = h.HeapSort();

            PrintArray(aSorted, "SortedHeap");
        }

        static void PrintArray<T>(T[] array, string name = "Array")
        {
            Console.Write("{0} = {{ ", name);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i].ToString());
                if (i < array.Length - 1)
                {
                    Console.Write(", ");
                }
                else
                {
                    Console.Write(" }\n");
                }
                    
            }
        }
    }
}
