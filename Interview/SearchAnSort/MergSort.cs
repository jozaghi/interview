using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.SearchAnSort
{
    public class MergSort
    {
        public int[] Sort(int[] array)
        {
            return Sort(array, 0, array.Length-1);
        }

        private int[] Sort(int[] array, int low, int hight)
        {
            if (hight==low) return new int[] { array[low] };

            var mid = (hight + low) / 2;
            var lowArray = Sort(array, low, mid);
            var hightArray = Sort(array, mid + 1, hight);
            return Merge(lowArray, hightArray);
        }

        private int[] Merge(int[] lowArray, int[] hightArray)
        {
            var result = new int[lowArray.Length + hightArray.Length];
            var resultIndex = 0;
            var lowIndex = 0;
            var highIndex = 0;
            while (lowIndex <lowArray.Length && highIndex< hightArray.Length)
            {
                if (lowArray[lowIndex] <= hightArray[highIndex])
                {
                    result[resultIndex++] = lowArray[lowIndex++];
                }
                else
                {
                    result[resultIndex++] = hightArray[highIndex++];
                }
            }
            for (int i = lowIndex; i < lowArray.Length; i++)
            {
                result[resultIndex++] = lowArray[lowIndex++];
            }
            for (int i = highIndex; i < hightArray.Length; i++)
            {
                result[resultIndex++] = hightArray[highIndex++];
            }
            return result;
        }
    }
}
