using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.LeetCode
{
    public class MostCommonWord
    {
        public string Find(string paragraph, string[] banned)
        {
            var banSet = new HashSet<string>(banned);
            var word = string.Empty;
            var visited = new Dictionary<string, int>();
            for (int i = 0; i < paragraph.Length; i++)
            {
                var currentChar = paragraph[i];

                if (currentChar == ' ' || char.IsPunctuation(currentChar))
                {
                    SetNewword(word, banSet, visited);
                    word = string.Empty;
                }
                else
                {
                    word += currentChar;
                }
            }
            SetNewword(word, banSet, visited);

            var mostVisitedword = string.Empty;
            var mostVisitedNum = 0;
            foreach (var item in visited)
            {
                if (item.Value > mostVisitedNum)
                {
                    mostVisitedword = item.Key;
                    mostVisitedNum = item.Value;
                }
            }
            return mostVisitedword;
        }

        private void SetNewword(string word, HashSet<string> banSet, Dictionary<string, int> visited)
        {
            if (word != string.Empty && !banSet.Contains(word.ToLower()))
            {
                var key = word.ToLower();
                visited[key] =
                    (visited.ContainsKey(key) ? visited[key] : 0) +
                    1;

            }
        }
    }
}
