using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.SearchAnSort
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            var longest = 0;
            var current = 0;
            var map = new HashSet<char>();
            var i = 0;
            while ( i < s.Length)
            {
                var cu = s[i];
                if (map.Contains(s[i]))
                {
                    if (longest <= current)
                    {
                        longest = current;
                    }
                    current = 0;
                    var repeatedChar = s[i];
                    while (s[i-1] != repeatedChar) i--;
                    map = new HashSet<char>();
                    
                }
                current++;
                map.Add(s[i]);
                i++;
            }
            return Math.Max( longest,current);
        }
    }
    public class SearchASortedArrayWithEmptyStrings
    {
        public bool Find(string[] array, string item)
        {
            throw new NotImplementedException();
        }



    }
}





