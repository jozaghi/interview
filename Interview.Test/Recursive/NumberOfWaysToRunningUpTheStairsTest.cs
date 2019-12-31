using FluentAssertions;
using Interview.Recursive;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Interview.Test.Recursive
{
    public class NumberOfWaysToRunningUpTheStairsTest
    {
        [Theory]
        [InlineData(0,1)]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 4)]
        [InlineData(30, 53798080)]
        [InlineData(35, 1132436852)]
        public void Calculate_GivenNumberOfStars_CalculateNumberOfWays(int stairs,int expectedNumberOfWays)
        {
            var result = new NumberOfWaysToRunningUpTheStairs().Calculate(stairs);

            result.Should().Be(expectedNumberOfWays);
        }
    }
}
