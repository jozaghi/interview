using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Shared
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public override int GetHashCode()
        {
            return $"X={X},Y={Y}".GetHashCode();
        }
    }
}
