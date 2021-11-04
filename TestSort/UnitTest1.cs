using System;
using NUnit.Framework;
using SortAlgorithms.Search;
using SortAlgorithms.Sorts;

namespace TestSort
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BubbleSortTest()
        {
            var intArray = new int[10000];
            var result = new int[10000];
            var random = new Random();
            for (var i = 0; i < intArray.Length; i++)
            {
                intArray[i] = random.Next();
                result[i] = intArray[i];
            }
            BubbleSort.Sort(intArray);
            Array.Sort(result);
            Assert.AreEqual(result, intArray);
        }
        
        [Test]
        public void SelectionSortTest()
        {
            var intArray = new int[10000];
            var result = new int[10000];
            var random = new Random();
            for (var i = 0; i < intArray.Length; i++)
            {
                intArray[i] = random.Next();
                result[i] = intArray[i];
            }
            SelectionSort.Sort(intArray);
            Array.Sort(result);
            Assert.AreEqual(result, intArray);
        }
        
        [Test]
        public void InsertionSortTest()
        {
            var intArray = new int[1000];
            var result = new int[1000];
            var random = new Random();
            for (var i = 0; i < intArray.Length; i++)
            {
                intArray[i] = random.Next();
                result[i] = intArray[i];
            }
            InsertionSort.Sort(intArray);
            Array.Sort(result);
            Assert.AreEqual(result, intArray);
        }
        
        [Test]
        public void ShellSortTest()
        {
            var intArray = new int[1000];
            var intArray2 = new int[1000];
            var result = new int[1000];
            var random = new Random();
            for (var i = 0; i < intArray.Length; i++)
            {
                intArray[i] = random.Next();
                result[i] = intArray[i];
                intArray2[i] = intArray[i];
            }
            InsertionSort.ShellSort(intArray);
            InsertionSort.ShellSort2(intArray2);
            Array.Sort(result);
            Assert.AreEqual(result, intArray);
            Assert.AreEqual(result, intArray2);
        }
        
        [Test]
        public void MergeSortTest()
        {
            var intArray = new int[1000];
            var result = new int[1000];
            var random = new Random();
            for (var i = 0; i < intArray.Length; i++)
            {
                intArray[i] = random.Next();
                result[i] = intArray[i];
            }
            MergeSort.Sort(intArray);
            Array.Sort(result);
            Assert.AreEqual(result, intArray);
        }
        
        [Test]
        public void QuickSortTest()
        {
            var intArray = new int[100000];
            var result = new int[100000];
            var random = new Random();
            for (var i = 0; i < intArray.Length; i++)
            {
                intArray[i] = random.Next();
                result[i] = intArray[i];
            }
            QuickSort.Sort(intArray);
            MergeSort.Sort(result);
            Assert.AreEqual(result, intArray);
        }

        [Test]
        public void CountingSortTest()
        {
            var intArray = new int[1000];
            var result = new int[1000];
            var random = new Random();
            for (var i = 0; i < intArray.Length; i++)
            {
                intArray[i] = random.Next(0, 1000);
                result[i] = intArray[i];
            }
            CountingSort.Sort(intArray);
            QuickSort.Sort(result);
            Assert.AreEqual(result, intArray);
        }

        [Test]
        public void RadixSortTest()
        {
            var intArray = new int[1000];
            var result = new int[1000];
            var random = new Random();
            for (var i = 0; i < intArray.Length; i++)
            {
                intArray[i] = random.Next(1000, 9999);
                result[i] = intArray[i];
            }

            //Radix taban, width basamak
            RadixSort.Sort(intArray, 10, 4);
            QuickSort.Sort(result);
            Assert.AreEqual(result, intArray);
        }

        [Test]
        public void BinarySearchTest()
        {
            var intArray = new int[1000];
            var random = new Random();
            for (var i = 0; i < intArray.Length; i++)
            {
                intArray[i] = random.Next(0, 1000);
            }
            MergeSort.Sort(intArray);
            int randomIndex = random.Next(0, 999);
            int testValue = BinarySearch.Search(intArray, intArray[randomIndex]);
            int result = Array.IndexOf(intArray, intArray[randomIndex]);
            Assert.AreEqual(result, testValue);
        }
        
        [Test]
        public void BucketSortTest()
        {
            var intArray = new int[1000];
            var result = new int[1000];
            var random = new Random();
            for (var i = 0; i < intArray.Length; i++)
            {
                intArray[i] = random.Next(1000, 9999);
                result[i] = intArray[i];
            }

            //Radix taban, width basamak
            BucketSort.Sort(intArray);
            QuickSort.Sort(result);
            Assert.AreEqual(result, intArray);
        }
        
        [Test]
        public void BogoSortTest()
        {
            var intArray = new int[7];
            var result = new int[7];
            var random = new Random();
            for (var i = 0; i < intArray.Length; i++)
            {
                intArray[i] = random.Next(1000, 9999);
                result[i] = intArray[i];
            }

            //Radix taban, width basamak
            BogoSort.Sort(intArray);
            MergeSort.Sort(result);
            Assert.AreEqual(result, intArray);
        }
        
        [Test]
        public void GnomeSortTest()
        {
            var intArray = new int[7];
            var result = new int[7];
            var random = new Random();
            for (var i = 0; i < intArray.Length; i++)
            {
                intArray[i] = random.Next(1000, 9999);
                result[i] = intArray[i];
            }

            //Radix taban, width basamak
            GnomeSort.StupidSort(intArray);
            MergeSort.Sort(result);
            Assert.AreEqual(result, intArray);
        }
        
        [Test]
        public void ShuffleSortTest()
        {
            var intArray = new int[1000];
            var result = new int[1000];
            var random = new Random();
            for (var i = 0; i < intArray.Length; i++)
            {
                intArray[i] = random.Next();
                result[i] = intArray[i];
            }
            CocktailShakerSort.Sort(intArray);
            Array.Sort(result);
            Assert.AreEqual(result, intArray);
        }
    }
}