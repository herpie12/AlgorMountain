using System;

namespace MethodsAL
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayTest = new int[] { 1, 3, 5, 7, 9 };

            int result = SearchMethods.LinearSearchFindPosition(arrayTest, 9);

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }

    public static class SearchMethods
    {

        public static int LinearSearchFindPosition(int[] array, int item)
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
    }
}
