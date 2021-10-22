using System.Collections.Generic;

namespace SortAlgorithms.Sorts
{
    public static class BubbleSort
    {
        public static void Sort(int[] numberArray)
        {
            //The last index of the unsorted property
            var unsortedPartitionIndex = numberArray.Length - 1;
            for (var i = 0; i < unsortedPartitionIndex + 1; i++)
            {
                if (i == unsortedPartitionIndex)
                {
                    //Resetting the loop
                    i = 0;
                    //Since we placed the correct index of the value to the last index, we decrement 1.
                    unsortedPartitionIndex--;
                }
                if (numberArray[i] <= numberArray[i + 1]) continue;
                Swap(numberArray, i, i+1);
            }
        }
        
        public static void Sort2(int[] numberArray)
        {
            for (var lastUnsortedIndex = numberArray.Length - 1; lastUnsortedIndex > 0; lastUnsortedIndex--)
                for (var i = 0; i < lastUnsortedIndex; i++)
                    if(numberArray[i] > numberArray[i+1])
                        Swap(numberArray, i, i+1);
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