using System;
namespace MethodsAL
{
    public static class SearchMethods
    {
        
            public static int LinearSearchFindIndex(int[] array, int item)
            {

                for (int i = 0; i < array.Length; i++)
                {

                    if (array[i] == item)
                    {
                        return i;
                    }
                }

                return 0;

            }

        public static int BinarySearchFindIndex(int[] array, int item)
        {

            int left = 0;
            int right = array.Length -1;

            while (left<= right)
            {
                var middle = (left + right) / 2;

                if (array[middle] == item)
                        return middle;

                if (item < array[middle])
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;

                }
            }

            return -1;
        }
    }
}
