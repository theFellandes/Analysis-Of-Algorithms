using System.Collections.Generic;

namespace SortAlgorithms.Sorts
{
    public class BucketSort
    {
        //This bucket sort doesn't sort the floating point numbers.
        public static void Sort(int[] intArray)
        {
            int maxValue = FindMax(intArray);
            int minValue = FindMin(intArray);
            int length = maxValue - minValue;
            List<int>[] bucket = new List<int>[length + 1];
            for (int i = 0; i < bucket.Length; i++)
            {
                bucket[i] = new List<int>();
            }

            foreach (var num in intArray)
            {
                bucket[num - minValue].Add(num);
            }

            int k = 0;
            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i].Count > 0)
                {
                    for (int j = 0; j < bucket[i].Count; j++)
                    {
                        intArray[k++] = bucket[i][j];
                    }
                }
            }
        }

        private static int FindMax(int[] intArray)
        {
            int maxValue = intArray[0];
            for (int i = 1; i < intArray.Length; i++)
                if (intArray[i] > maxValue)
                    maxValue = intArray[i];
            return maxValue;
        }
        
        private static int FindMin(int[] intArray)
        {
            int minValue = intArray[0];
            for (int i = 1; i < intArray.Length; i++)
                if (intArray[i] < minValue)
                    minValue = intArray[i];
            return minValue;
        }

        //This implementation haven't been tested. Probably works though.
        public static void Sort2(int[] input)
        {
            List<int>[] buckets = new List<int>[10];

            for (int i = 0; i < buckets.Length; i++)
            {
                buckets[i] = new List<int>();
            }

            foreach (var num in input)
            {
                buckets[Hash(num)].Add(num);
            }

            foreach (var bucket in buckets)
            {
                bucket.Sort();
            }

            int j = 0;
            foreach (var bucket in buckets)
            {
                foreach (int value in bucket)
                {
                    input[j++] = value;
                }
            }

        }

        private static int Hash(int value)
        {
            //This can change with the size of the list however in this application we are
            //sorting only 10's position
            return value / 10;
        }
    }
}