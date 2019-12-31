using FluentAssertions;
using Interview.LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Interview.Test.LeetCode
{
    public class ContainerWithMostWaterTest
    {
        [Theory]
        [InlineData(new int[]{},0)]
        [InlineData(new int[]{ 1, 8, 6, 2, 5, 4, 8, 3, 7 },49)]
        [InlineData(new int[]{ 1,1 },1)]
        public void MaxArea_GivenAnIntArray_ReturnMaxArea(int[] array,int expectedResult)
        {
            var cwmw = new ContainerWithMostWater();
            var result = cwmw.MaxArea(array);
            result.Should().Be(expectedResult);
        }
    }
}

 