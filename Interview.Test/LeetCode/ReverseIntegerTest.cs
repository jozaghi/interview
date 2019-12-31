using FluentAssertions;
using Interview.LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Interview.Test.LeetCode
{
    public class ReverseIntegerTest
    {
        [Theory]
        [InlineData(123,321)]
        [InlineData(120,21)]
        [InlineData(-123,-321)]
        [InlineData(1534236469, 0)]
        
        public void Reverse(int num, int expected)
        {
            var ri = new ReverseInteger();
            var result = ri.Reverse(num);
            result.Should().Be(expected);
        }
    }
}
