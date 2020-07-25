using System;
using MethodsAL;
using Xunit;

namespace MethodTesting
{
    public class UnitTestMethods
    {
        [Theory]
        [InlineData(new int[] { 1, 3, 5, 7, 9 }, 3, 1)]
        [InlineData(new int[] { 1, 3, 5, 7, 9 }, 5, 2)]
        public void LinearSearchTestPass(int[] array, int item, int expectedPosition)
        {
            var foundposition = SearchMethods.LinearSearchFindIndex(array, item);

            Assert.Equal(expectedPosition, foundposition);
        }

        [Theory]
        [InlineData(new int[] { 1, 3, 5, 7, 9 }, 3, 4)]
        [InlineData(new int[] { 1, 3, 5, 7, 9 }, 5, 1)]
        public void LinearSearchTestFail(int[] array, int item, int expectedPosition)
        {
            var foundposition = SearchMethods.LinearSearchFindIndex(array, item);

            Assert.NotEqual(expectedPosition, foundposition);
        }

        [Theory]
        [InlineData(new int[] { 1, 3, 5, 7, 9 }, 3, 1)]
        [InlineData(new int[] { 1, 3, 5, 7, 9 }, 5, 2)]
        public void BinarySearchTest(int[] array, int item, int expectedPosition)
        {
            var foundposition = SearchMethods.BinarySearchFindIndex(array, item);

            Assert.Equal(expectedPosition, foundposition);
        }
    }
}
