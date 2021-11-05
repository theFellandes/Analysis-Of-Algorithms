namespace SortAlgorithms.Sorts
{
    public class GnomeSort
    {
        public static void StupidSort(int[] intArray)
        {
            for (int i = 1; i < intArray.Length;)
            {
                if (intArray[i - 1] <= intArray[i])
                    ++i;
                else
                {
                    Swap(intArray, i, i-1);
                    --i;
                    if (i == 0)
                        i = 1; 
                }
            }
        }

        private static void Swap(int[] intArray, int index1, int index2)
        {
            (intArray[index1], intArray[index2]) = (intArray[index2], intArray[index1]);
        }
    }
}