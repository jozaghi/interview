using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Interview.StringsAndArrays
{
    public class StringQuestions
    {
        #region string has unique chars
        public bool IsStringHasUniqueChars(string @string)
        {
            var hashSet = new HashSet<char>();
            for (int i = 0; i < @string.Length; i++)
            {
                if (hashSet.Contains(@string[i]))
                {
                    return false;
                }
                hashSet.Add(@string[i]);
            }
            return true;
        }

        #endregion

        #region get all permutation of a string
        public string[] GetAllPermutation(string input)
        {
            var result = new List<string>();
            CalculateAllPermutation(input,0, result);
            return result.ToArray();
        }
        private void CalculateAllPermutation(string input,int pivot ,List<string> result)
        {
            if (input.Length - pivot  <= 1)
            {
                result.Add(input);
                return;
            }

            for (int i = pivot; i < input.Length; i++)
            {
                var newInput = SwapChars(input, pivot, i);
                CalculateAllPermutation(newInput, pivot + 1, result);
            }
        }

        private string SwapChars(string input, int pivot, int i)
        {
            var arr= input.ToCharArray();
            var pivotChar = arr[pivot];
            arr[pivot] = arr[i];
            arr[i] = pivotChar;
            return new string(arr);
        }


        #endregion

        #region compress string
        public string Compress(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;
            StringBuilder result = new StringBuilder();
            Stack<char> visited = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                if (visited.TryPeek(out char lastVisited) && lastVisited != input[i])
                {
                    result.Append(GetCharWithItsNumbers(visited, lastVisited));
                }
                visited.Push(input[i]);
            }
            result.Append(GetCharWithItsNumbers(visited, input[input.Length-1]));

            return result.Length<input.Length?
                   result.ToString():
                   input;
        }

       

        public string GetCharWithItsNumbers(Stack<char> visited,char inputChar)
        {
            var result= $"{inputChar}{visited.Count.ToString()}";
            visited.Clear();
            return result;
        }
        #endregion

        #region rotate matrix
        public int[,] RotateMatrix(int[,] matrix)
        {
            var n = matrix.GetLength(0);

            for (int layer = 0; layer < n/2; layer++)
            {
                var first = layer;
                var last = n - 1 - first;
                for (int i = first; i < last; i++)
                {
                    var offset = i - first;
                    var temp = matrix[first, i];
                    matrix[first, i] = matrix[last - offset,first];
                    matrix[last - offset, first] = matrix[last, last - offset];
                    matrix[last, last - offset] = matrix[i, last];
                    matrix[i, last] = temp;
                }
            }



            return matrix;
        }
        #endregion
    }
}
