using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.LeetCode
{
    public class RomanToInteger
    {
        public int RomanToInt(string romanNumber)
        {
            var result = 0;
            var map = new Dictionary<string, int> {
                { "I", 1 },
                { "IV", 4 },
                { "V", 5 },
                { "IX", 9 },
                { "X", 10 },
                { "XL", 40 },
                { "L", 50 },
                { "XC", 90 },
                { "C", 100 },
                { "CD", 400 },
                { "D", 500 },
                { "CM", 900 },
                { "M", 1000 }
            };
            for (int i = 0; i < romanNumber.Length; i++)
            {
                if ((i + 1 < romanNumber.Length && map.ContainsKey($"{romanNumber[i]}{romanNumber[i + 1]}")))
                {
                    result += map[$"{romanNumber[i]}{romanNumber[i + 1]}"];
                    i++;
                }
                else
                {
                    result += map[$"{romanNumber[i]}"];
                }
            }
            return result;
        }
    }
}