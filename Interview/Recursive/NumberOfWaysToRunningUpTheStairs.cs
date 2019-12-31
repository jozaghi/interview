
using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Recursive
{
    public class NumberOfWaysToRunningUpTheStairs
    {
        private Dictionary<int, int> _Cache = new Dictionary<int, int>();
        public int Calculate(int stairs)
        {
            if (stairs == 0) return 1;
            if (stairs < 0) return 0;
            //return Calculate(stairs - 1) + Calculate(stairs - 2) + Calculate(stairs - 3);
            if (!_Cache.ContainsKey(stairs))
            {
                _Cache[stairs] = Calculate(stairs - 1) + Calculate(stairs - 2) + Calculate(stairs - 3);
            }
            return _Cache[stairs];
        }
    }
}
