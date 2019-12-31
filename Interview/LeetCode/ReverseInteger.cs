using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.LeetCode
{
    public class ReverseInteger
    {
        public int Reverse(int num)
        {
            try
            {
                checked
                {
                    bool signedFactor = false;
                    if (num < 0)
                    {
                        num = num * -1;
                        signedFactor = true;
                    }
                    Int32 result = 0;
                    while (num > 0)
                    {
                        result = (num % 10) + (result * 10);
                        num = num / 10;

                    }
                    result = result * (signedFactor?-1:1);
                    return result;
                }
            }
            catch
            {
                return 0;
            }
           
        }
    }
}
