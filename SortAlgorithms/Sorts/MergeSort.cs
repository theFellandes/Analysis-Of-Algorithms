using System;

namespace SortAlgorithms.Sorts
{
    public static class MergeSort
    {
        /// <summary>
        /// Method Overloading for the Sort function to not use magic strings
        /// </summary>
        /// <param name="intArray">input array</param>
        public static void Sort(int[] intArray)
        {
            Sort(intArray, 0, intArray.Length);
        }
        
        /// <summary>
        /// Sorting phase of the MergeSort
        /// Recursive implementation
        /// </summary>
        /// <param name="intArray">input array</param>
        /// <param name="start">start index of the sub array</param>
        /// <param name="end">end index of the sub array</param>
        private static void Sort(int[] intArray, int start, int end)
        {
            //Recursion breaker condition
            if (end - start < 2)
                return;
            //Partition part and finding start and end indices of the array
            int midPoint = (start + end) / 2;
            //Merge sort on the left array
            Sort(intArray, start, midPoint);
            //Merge sort on the right array
            Sort(intArray, midPoint, end);
            //When we hit this part, we will merge the left and right sub arrays
            Merge(intArray, start, midPoint, end);
        }

        /// <summary>
        /// Merging part of the merge sort
        /// </summary>
        /// <param name="intArray">input array</param>
        /// <param name="start">start index of the sub array</param>
        /// <param name="mid">midpoint of the sub array</param>
        /// <param name="end">end of the sub array</param>
        private static void Merge(int[] intArray, int start, int mid, int end)
        {
            //1st Optimization
            //mid - 1 is the last element of the left partition and mid is the first element of the right partition
            // if the last element in the left partition is less than or equal to the first element of the
            //  right partition, that means all the elements in the left partition are less than or equal to the right.
            //   then we know all of the left and right partition are sorted. We just need to copy the entire left and
            //    right array and then stick them together. Because they are already sorted.
            if (intArray[mid - 1] <= intArray[mid])
                return;

            int i = start;
            int j = mid;
            //Keeping track of the temp array's index position
            int tempIndex = 0;

            int[] temp = new int[end - start];
            //as soon as we traversing either left or the right array, we drop out the loop
            // we will handle the leftovers later.
            while (i < mid && j < end)
            {
                //<= because we need to make the algorithm stable. If there is no equality, then the algorithm becomes
                // unstable.
                temp[tempIndex++] = intArray[i] <= intArray[j] ? intArray[i++] : intArray[j++];
            }
            
            //2nd Optimization, handling the remaining elements.
            // If we have leftovers in the left array, we need to copy those elements to the temp array however
            //  if we have leftovers in the right array, we don't need to do anything, it's the same situation as the
            //   first optimization. Since we copy the left and right array to the temporary array, if we were to
            //    add the right array's leftover, we would just end up by overwriting the same value. Needless work.
            //     If we have seen all of the left array, we would know that every element in the right array would be
            //      greater than the left array. Right array's leftover's wouldn't change their positions however
            //       the leftovers at the left array will change their positions.
            
            // The index for the leftover element of the left index would be i.
            //length will tell us the number of elements we didn't copy from the left array
            // it's just handling the left array's leftover elements. 
            // this doesn't care about the right array
            Array.Copy(intArray, i, intArray, start + tempIndex, mid - i);
            Array.Copy(temp, 0, intArray, start, tempIndex);
        }

        public static void SortAsc(int[] intArray)
        {
            SortAsc(intArray, 0, intArray.Length);
        }
        
        /// <summary>
        /// Sorting phase of the MergeSort
        /// Sorts ascending order
        /// Recursive implementation
        /// </summary>
        /// <param name="intArray">input array</param>
        /// <param name="start">start index of the sub array</param>
        /// <param name="end">end index of the sub array</param>
        private static void SortAsc(int[] intArray, int start, int end)
        {
            //Recursion breaker condition
            if (end - start < 2)
                return;
            //Partition part and finding start and end indices of the array
            int midPoint = (start + end) / 2;
            //Merge sort on the left array
            SortAsc(intArray, start, midPoint);
            //Merge sort on the right array
            SortAsc(intArray, midPoint, end);
            //When we hit this part, we will merge the left and right sub arrays
            MergeAsc(intArray, start, midPoint, end);
        }
        
        /// <summary>
        /// Merging part of the merge sort
        /// Ascending order
        /// </summary>
        /// <param name="intArray">input array</param>
        /// <param name="start">start index of the sub array</param>
        /// <param name="mid">midpoint of the sub array</param>
        /// <param name="end">end of the sub array</param>
        private static void MergeAsc(int[] intArray, int start, int mid, int end)
        {
            //1st Optimization
            //mid - 1 is the last element of the left partition and mid is the first element of the right partition
            // if the last element in the left partition is less than or equal to the first element of the
            //  right partition, that means all the elements in the left partition are less than or equal to the right.
            //   then we know all of the left and right partition are sorted. We just need to copy the entire left and
            //    right array and then stick them together. Because they are already sorted.
            if (intArray[mid - 1] >= intArray[mid])
                return;

            int i = start;
            int j = mid;
            //Keeping track of the temp array's index position
            int tempIndex = 0;

            int[] temp = new int[end - start];
            //as soon as we traversing either left or the right array, we drop out the loop
            // we will handle the leftovers later.
            while (i < mid && j < end)
            {
                //<= because we need to make the algorithm stable. If there is no equality, then the algorithm becomes
                // unstable.
                temp[tempIndex++] = intArray[i] >= intArray[j] ? intArray[i++] : intArray[j++];
            }
            
            //2nd Optimization, handling the remaining elements.
            // If we have leftovers in the left array, we need to copy those elements to the temp array however
            //  if we have leftovers in the right array, we don't need to do anything, it's the same situation as the
            //   first optimization. Since we copy the left and right array to the temporary array, if we were to
            //    add the right array's leftover, we would just end up by overwriting the same value. Needless work.
            //     If we have seen all of the left array, we would know that every element in the right array would be
            //      greater than the left array. Right array's leftover's wouldn't change their positions however
            //       the leftovers at the left array will change their positions.
            
            // The index for the leftover element of the left index would be i.
            //length will tell us the number of elements we didn't copy from the left array
            // it's just handling the left array's leftover elements. 
            // this doesn't care about the right array
            Array.Copy(intArray, i, intArray, start + tempIndex, mid - i);
            Array.Copy(temp, 0, intArray, start, tempIndex);
        }
    }
}