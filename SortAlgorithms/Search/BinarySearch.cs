namespace SortAlgorithms.Search
{
    public class BinarySearch
    {
        public static int Search(int[] intArray, int searchValue)
        {
            int i = 1;
            int j = intArray.Length - 1;
            while (i < j)
            {
                int m = (i + j) / 2;
                if (searchValue > intArray[m])
                    i = m + 1;
                else
                    j = m;
            }

            if (searchValue == intArray[i])
                return i;
            return 0;
        }
    }
}