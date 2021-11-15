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
        
        public static void StringSort(string[] stringArray, int radix, int width)
        {
            for (int i = width - 1; i >= 0; i--)
            {
                RadixStringSort(stringArray, i, radix);
            }
        }
        
        private static void RadixStringSort(string[] stringArray, int position, int radix)
        {
            int numItems = stringArray.Length;
            int[] countArray = new int[radix];
            
            foreach(var value in stringArray)
            {
                countArray[GetIndex(position, value)]++;
            }

            //Adjust the countArray
            for (int j = 1; j < radix; j++)
            {
                countArray[j] += countArray[j - 1];
            }

            var temp = new string[numItems];
            for (int tempIndex = numItems - 1; tempIndex > -1; tempIndex--)
            {
                temp[--countArray[GetIndex(position, stringArray[tempIndex])]] = stringArray[tempIndex];
            }

            //Array copying
            for (int tempIndex = 0; tempIndex < numItems; tempIndex++)
            {
                stringArray[tempIndex] = temp[tempIndex];
            }
        }

        private static int GetIndex(int position, string value)
        {
            return value[position] - 'a';
        }
    }
}