using FluentAssertions;
using Interview.LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Interview.Test.LeetCode
{
    public class RomanToIntegerTest
    {
        [Theory]
        [InlineData("I", 1)]
        [InlineData("III", 3)]
        [InlineData("IV", 4)]
        [InlineData("IX", 9)]
        [InlineData("LVIII", 58)]
        [InlineData("MCMXCIV", 1994)]
        public void RomanToInt_GivenRomanNumber_ReturinsEquevalentInteger(string romanNumber, int expected)
        {
            var rti = new RomanToInteger();
            var result = rti.RomanToInt(romanNumber);
            result.Should().Be(expected);
        }
    }
}
