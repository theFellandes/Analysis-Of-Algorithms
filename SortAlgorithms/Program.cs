using System;
using SortAlgorithms.Hash;
using SortAlgorithms.Sorts;
using SortAlgorithms.Search;
using SortAlgorithms.Heap;

namespace SortAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTest();
        }

        static void HashTest()
        {
            HashTableExample hashTable = new HashTableExample(10);
            hashTable.Put("Jones", new Employee("Jane", "Jones", 123));
            hashTable.Put("Doe", new Employee("Jane", "Doe", 4312));
            hashTable.Put("Smith", new Employee("Mary", "Smith", 555));
            hashTable.PrintHashtable();
        }

        static void HeapObserve()
        {
            MaxHeap heap = new MaxHeap(10);

            heap.Insert(80);
            heap.Insert(75);
            heap.Insert(60);
            heap.Insert(68);
            heap.Insert(55);
            heap.Insert(40);
            heap.Insert(52);
            heap.Insert(67);
            
            heap.PrintHeap();

            heap.Delete(1);
            
            heap.PrintHeap();
        }

        static void TestSorts()
        {
            int[] testArray = {20, 35, -15, 7, 55, 1, -22, 3, 99};
            // int[] testArray = {20, 35, 15, 7, 15, 1, 22, 3, 99};
            CountingSort.Sort(testArray);
            foreach (var num in testArray)
            { 
                Console.Write(num + " ");
            }
            // int[] testArray = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int indexOf = Array.IndexOf(testArray, 8);
            int index = BinarySearch.Search(testArray, 8);
            Console.WriteLine(index);
            Console.WriteLine(indexOf);
        }
        
    }
}