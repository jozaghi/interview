using FluentAssertions;
using Interview.SearchAnSort;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Interview.Test.SearchAndSort
{
    public class SearchASortedArrayWithEmptyStringsTest
    {
        [Fact]
        public void Find_GivenAnArray_FindTheItem()
        {
            var array = new string[] { };
            var item = "";
            var search = new SearchASortedArrayWithEmptyStrings();

            var result = search.Find(array, item);

            result.Should().Be(true);
        }


        [Fact]
        public void Test()
        {
            var s = new Solution();

            var r = s.LengthOfLongestSubstring("ggububgvfk");

            r.Should().Be(6);
        }
    }
}
