using System;

namespace SortAlgorithms.Sorts
{
    public class BogoSort
    {
        //This sort algorithm is just made for fun.
        // DO NOT TRY THIS AT HOME!!!
        //Best case: Omega(1) Worst Case: O(infinity)
        public static void Sort(int[] intArray)
        {
            while(!IsSorted(ref intArray))
                Shuffle(ref intArray);
        }

        private static void Shuffle(ref int[] intArray)
        {
            Random random = new Random();
            for (int i = 0; i < intArray.Length; i++)
            {
                int randomIndex = random.Next(intArray.Length);
                Swap(intArray, i, randomIndex);
            }
        }

        private static void Swap(int[] intArray, int index1, int index2)
        {
            int temp = intArray[index2];
            intArray[index2] = intArray[index1];
            intArray[index1] = temp;
        }

        private static bool IsSorted(ref int[] intArray)
        {
            int count = intArray.Length;
            while(--count >= 1)
                if (intArray[count] < intArray[count - 1])
                    return false;
            return true;
        }
    }
}