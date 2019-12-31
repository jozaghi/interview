using FluentAssertions;
using Interview.LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Interview.Test.LeetCode
{
    public class LongestCommonPrefixTest
    {
        [Theory]
        [InlineData(new string[]{ "flower", "flow", "flight" }, "fl")]
        [InlineData(new string[]{ "dog", "racecar", "car" }, "")]
        public void Find(string[] array,string expectedProfix)
        {
            var result = new LongestCommonPrefix().Find(array);
            result.Should().Be(expectedProfix);
        }
    }
}
