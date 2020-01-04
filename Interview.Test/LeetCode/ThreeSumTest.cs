using Interview.LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Interview.Test.LeetCode
{
    public class ThreeSumTest
    {
        [Fact]
        public void Test()
        {
            var r = new ThreeSum().Test(new int[] { -1, 0, 1, 2, -1, -4});
            
        }
    }
}
