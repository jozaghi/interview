using Interview.LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Interview.Test.LeetCode
{
    
    public class LRUTest
    {
        [Fact]
        public void Test()
        {
            //[3],[1,1],[2,2],[3,3],[4,4],[4],[3],[2],[1],[5,5],[1],[2],[3],[4],[5]]
            var l = new LRUCache(3);
            l.Put(1, 1);
            l.Put(2, 2);
            l.Put(3, 3);
            l.Put(4, 4);
            var a1 = l.Get(4);
            var a2 = l.Get(3);
            var a3 = l.Get(2);
            var a4 = l.Get(1);
            l.Put(5, 5);
            var a5 = l.Get(1);
            var a6 = l.Get(2);
            var a7 = l.Get(3);
            var a8 = l.Get(4);
            var a9 = l.Get(5);


        }
    }
}
