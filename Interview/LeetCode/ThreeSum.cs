using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interview.LeetCode
{
    public class ThreeSum
    {
        public IList<IList<int>> Test(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();

            var s = new List<int>();
            for (var i = 0; i < nums.Length - 1; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    var x = -(nums[i] + nums[j]);
                    if (s.Contains(x))
                    {
                        var seq = new List<int> { x, nums[i], nums[j] };
                        if (!result.Any(p => p.All(l => seq.Contains(l))))
                            result.Add(seq);
                    }
                    else
                    {
                        s.Add(nums[i]);
                    }
                }
            }

            return result;
        }
    }
}
