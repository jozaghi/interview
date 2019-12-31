using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.LeetCode
{
    public class LongestCommonPrefix
    {
        public string Find(string[] array)
        {
            var prefix = string.Empty;
            if (array.Length == 0) return string.Empty;
            if (array.Length == 1) return array[0];

            for (int i = 0; i < array[0].Length; i++)
            {
                var tempPrefix = prefix + array[0][i];
                for (int j = 1; j < array.Length; j++)
                {
                    if (!array[j].StartsWith(tempPrefix)) return prefix;
                }
                prefix = tempPrefix;
            }
            return prefix;
        }
    }
}
