using System.Collections.Generic;

namespace SortAlgorithms.Sorts
{
    public static class SelectionSort
    {
        public static void Sort(int[] numberArray)
        {
            var lastUnsortedIndex = numberArray.Length - 1;
            var largest = 0;
            for (var i = 1; i < lastUnsortedIndex + 1; i++)
            {

                if (numberArray[i] > numberArray[largest])
                    largest = i;

                if (i != lastUnsortedIndex) continue;
                Swap(numberArray, lastUnsortedIndex, largest);
                i = 0;
                largest = 0;
                lastUnsortedIndex--;
            }
        }

        public static void Sort2(int[] numberArray)
        {
            for (var lastUnsortedIndex = numberArray.Length - 1; lastUnsortedIndex > 0; lastUnsortedIndex--)
            {
                var largest = 0;
                for (var i = 1; i <= lastUnsortedIndex; i++)
                    if (numberArray[i] > numberArray[largest])
                        largest = i;
                
                Swap(numberArray, largest, lastUnsortedIndex);
            }
        }

        /// <summary>
        /// A swap method that swaps the values inside the array
        /// </summary>
        /// <param name="array"> the array that we want to swap its values </param>
        /// <param name="i"> index 1 </param>
        /// <param name="j"> index 2 </param>
        private static void Swap(IList<int> array, int i, int j)
        {
            if (i == j) return;
            var temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}