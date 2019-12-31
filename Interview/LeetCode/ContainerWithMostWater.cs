using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.LeetCode
{
    public class ContainerWithMostWater
    {
        public int MaxArea(int[] array)
        {
            int maxArea = 0, left = 0, right = array.Length-1;
            while (left<right)
            {
                maxArea = Math.Max(maxArea, Math.Min(array[left], array[right]) * (right - left));
                if (array[left]< array[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return maxArea;
        }
    }
}
