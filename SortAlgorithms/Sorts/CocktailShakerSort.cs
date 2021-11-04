namespace SortAlgorithms.Sorts
{
    public class CocktailShakerSort
    {
        private static void Swap(int[] intArray, int index1, int index2)
        {
            int temp = intArray[index1];
            intArray[index1] = intArray[index2];
            intArray[index2] = temp;
        }

        public static void Sort(int[] intArray)
        {
            while (true)
            {
                bool flag;
                int[] start = {1, intArray.Length - 1};
                int[] end = {intArray.Length, 0};
                int[] increment = {1, -1};
                for (int it = 0; it < 2; ++it)
                {
                    flag = true;
                    for (int i = start[it]; i != end[it]; i += increment[it])
                    {
                        if (intArray[i - 1] > intArray[i])
                        {
                            Swap(intArray, i-1, i);
                            flag = false;
                        }
                    }

                    if (flag)
                        return;
                }
            }
        }
    }
}