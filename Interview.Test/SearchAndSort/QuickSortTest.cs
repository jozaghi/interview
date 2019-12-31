using FluentAssertions;
using Interview.SearchAnSort;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Interview.Test.SearchAndSort
{
    public class QuickSortTest
    {
        [Theory]
        [InlineData(new int[] { 3, 5, 1, 44, 8, 0 }, new int[] { 0, 1, 3, 5, 8, 44 })]
        [InlineData(new int[] { 3, 3, 7, 44, 8, 0 }, new int[] { 0, 3, 3, 7, 8, 44 })]
        public void Sort_GivenArrayOfInteger_ReturnsSortedArray(int[] array, int[] expectedResult)
        {
            var quickSort = new QuickSort();

            var result = quickSort.Sort(array);

            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}
