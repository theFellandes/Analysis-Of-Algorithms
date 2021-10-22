using System;

namespace SortAlgorithms.Sorts
{
    public static class InsertionSort
    {
        
        public static void Sort(int[] intArray)
        {
            for (var firstUnsortedIndex = 1; firstUnsortedIndex < intArray.Length; firstUnsortedIndex++)
            {
                var newElement = intArray[firstUnsortedIndex];
                //We need this i after the loop
                int i;
                //we want to keep looking for the insertion position as long as we haven't hit the front
                // of the array, because if we hit the front of the array, it means that the element
                //  we are trying to insert is the smallest element we've seen so far and the correct insertion
                //   position is zero and we want to keep looking as long as the element we're looking at in the
                //    sorted partition is greater than the one we're trying to insert, because if the element at i - 1
                //     is greater than the element we're trying to insert, then we still haven't found the correct
                //      insertion position. So the moment we hit the front of the array, or the moment we hit an
                //       element that is less than or equal to the element we're trying to insert, we have found the
                //        correct insertion position.
                for (i = firstUnsortedIndex; i > 0 && intArray[i - 1] > newElement; i--)
                {
                    //shifting the element Left to right shifting.
                    intArray[i] = intArray[i - 1];
                }

                intArray[i] = newElement;
            }
        }

        public static void ShellSort(int[] intArray)
        {
            int k = 1;
            for (int gap =  2 * (intArray.Length /  (int) Math.Pow(2, k + 1)) + 1; 
                2 * intArray.Length / (int) Math.Pow(2, k + 1) > 0; 
                k++, gap = 2 * (intArray.Length / (int) Math.Pow(2, k + 1)) + 1)
            {
                for (int i = gap; i < intArray.Length; i++)
                {
                    int newElement = intArray[i];
                    int j = i; //traversing
                    //if j becomes less than gap, then we hit the front of the array
                    while (j >= gap && intArray[j - gap] > newElement)
                    {
                        //Shift up gap positions
                        intArray[j] = intArray[j - gap];
                        j -= gap;
                    }
                    intArray[j] = newElement;
                }
            }
        }

        public static void ShellSort2(int[] intArray)
        {
            for (int gap = intArray.Length / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < intArray.Length; i++)
                {
                    int newElement = intArray[i];
                    int j = i; //traversing
                    //if j becomes less than gap, then we hit the front of the array
                    while (j >= gap && intArray[j - gap] > newElement)
                    {
                        //Shift up gap positions
                        intArray[j] = intArray[j - gap];
                        j -= gap;
                    }
                    intArray[j] = newElement;
                }
            }
        }
        
        
    }
}