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
            var world = string.Empty;
            var visited = new Dictionary<string, int>();
            for (int i = 0; i < paragraph.Length; i++)
            {
                var currentChar = paragraph[i];

                if (currentChar == ' ' || char.IsPunctuation(currentChar))
                {
                    SetNewWorld(world, banSet, visited);
                    world = string.Empty;
                }
                else
                {
                    world += currentChar;
                }
            }
            SetNewWorld(world, banSet, visited);

            var mostVisitedWorld = string.Empty;
            var mostVisitedNum = 0;
            foreach (var item in visited)
            {
                if (item.Value > mostVisitedNum)
                {
                    mostVisitedWorld = item.Key;
                    mostVisitedNum = item.Value;
                }
            }
            return mostVisitedWorld;
        }

        private void SetNewWorld(string world, HashSet<string> banSet, Dictionary<string, int> visited)
        {
            if (world != string.Empty && !banSet.Contains(world.ToLower()))
            {
                var key = world.ToLower();
                visited[key] =
                    (visited.ContainsKey(key) ? visited[key] : 0) +
                    1;

            }
        }
    }
}
