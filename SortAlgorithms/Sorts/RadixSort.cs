using System;

namespace SortAlgorithms.Sorts
{
    public static class RadixSort
    {

        public static void Sort(int[] intArray, int radix, int width)
        {
            for (int i = 0; i < width; i++)
            {
                RadixSingleSort(intArray, i, radix);
            }
        }

        private static void RadixSingleSort(int[] intArray, int position, int radix)
        {
            int numItems = intArray.Length;
            int[] countArray = new int[radix];
            
            foreach(var value in intArray)
            {
                countArray[GetDigit(position, value, radix)]++;
            }

            //Adjust the countArray
            for (int j = 1; j < radix; j++)
            {
                countArray[j] += countArray[j - 1];
            }

            int[] temp = new int[numItems];
            for (int tempIndex = numItems - 1; tempIndex > -1; tempIndex--)
            {
                temp[--countArray[GetDigit(position, intArray[tempIndex], radix)]] = intArray[tempIndex];
            }

            //Array copying
            for (int tempIndex = 0; tempIndex < numItems; tempIndex++)
            {
                intArray[tempIndex] = temp[tempIndex];
            }
        }

        private static int GetDigit(int position, int value, int radix)
        {
            return value / (int) Math.Pow(radix, position) % radix;
        }
    }
}