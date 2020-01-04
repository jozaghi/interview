using FluentAssertions;
using Interview.LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Interview.Test.LeetCode
{
    public class SearchTextTest
    {
        [Fact]
        public void Search()
        {
            var s = new SearchText();
            var result = s.Search(
                "The type to assign to the type parameter of the returned generic",
                "to"
                );
            result.Should().HaveCount(2);
        }

        [Fact]
        public void Search2()
        {
            var s = new SearchText();
            var result = s.Search2(
                "The type to assign to the type parameter of the returned generic",
                "assign"
                );
            result.Should().HaveCount(1);
            var a= result;
        }
    }
}
