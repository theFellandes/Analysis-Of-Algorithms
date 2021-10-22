using System;

namespace SortAlgorithms.Sorts
{
    public static class CountingSort
    {

        public static void Sort(int[] intArray)
        {
            int max = -1;
            int min = int.MaxValue;
            foreach (int num in intArray)
            {
                if (max < num)
                    max = num;
                if (min > num)
                    min = num;
            }

            int size = max - min;
            int[] countingArray = new int[size + 2];
            foreach (int num in intArray)
            {
                countingArray[num]++;
            }

            int index = 0;
            for (int i = 0; i < countingArray.Length; i++)
            {
                while (countingArray[i] != 0)
                {
                    intArray[index++] = i;
                    countingArray[i]--;
                }
            }
        }

        public static void Sort2(int[] intArray, int min, int max)
        {
            int[] countArray = new int[max - min + 1];
            foreach (var num in intArray)
            {
                //translating the value according to min and finding the index
                countArray[num - min]++;
            }

            //for writing to intArray
            int index = 0;
            //traversing the countArray
            for (int i = min; i <= max; i++)
            {
                while (countArray[i - min] > 0)
                {
                    intArray[index++] = i;
                    countArray[i - min]--; 
                }
            }
        }
    }
}