using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.SearchAnSort
{
    public class QuickSort
    {
        public int[] Sort(int[] array)
        {
            Sort(array, 0, array.Length-1);
            return array;
        }

        private void Sort(int[] array, int left, int right)
        {
            var index = Partition(array, left, right);
            if (left<index-1)
            {
                Sort(array, left, index - 1);
            }
            if (right > index)
            {
                Sort(array, index, right);
            }
        }

        private int Partition(int[] array, int left, int right)
        {
            int pivot = array[(left + right) / 2];
            while (left<=right)
            {
                while (array[left] < pivot) left++;
                while (array[right] > pivot) right--;

                if (left<=right)
                {
                    Swap(array, left, right);
                    left++;
                    right--;
                }
            }
            return left;
        }

        private void Swap(int[] array, int left, int right)
        {
            var temp = array[left];
            array[left] = array[right];
            array[right] = temp;
        }
    }
}
