using FluentAssertions;
using Interview.LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Interview.Test.LeetCode
{
    public class MostCommonWordTest
    {
        [Theory]
        [InlineData("Bob hit a ball, the hit BALL flew far after it was hit.", new string[] { "hit" },"ball")]
        public void TestFind(string paragraph, string[] bannedList, string expected)
        {
            var m = new MostCommonWord();
            var result = m.Find(paragraph, bannedList);

            result.Should().Be(expected);
        }
    }
}
