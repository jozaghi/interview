using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interview.LeetCode
{
    public class SearchResult
    {
        public int From { get; set; }
        public int Length { get; set; }
        public SearchResult(int @from, int length)
        {
            From = @from;
            Length = length;
        }
    }
    public class SearchText
    {

		private Dictionary<char, int> CreateSkipMap(string textToFind)
		{
			var map = new Dictionary<char, int>();
			var defaultSkipLength = textToFind.Length;
			for (var i = 0; i < textToFind.Length-1; i++)
			{
				if (map.ContainsKey(textToFind[i])){
					map[textToFind[i]] = textToFind.Length -i-1;
				}
				else
				{
					map.Add(textToFind[i], textToFind.Length - i - 1);
				}
			}
			return map;
		}

		public IEnumerable<SearchResult> Search2(string textToSearch, string textToFind)
		{
			if (string.IsNullOrEmpty(textToFind) ||
			   string.IsNullOrEmpty(textToSearch) ||
			   textToSearch.Length < textToFind.Length) yield break;
			var map = CreateSkipMap(textToFind);
			var defaultSkipLength = textToFind.Length-1;

            for (int i = 0; i < textToSearch.Length - textToFind.Length; i++)
            {
                var charToFind = textToFind.Length - 1;
                while (charToFind >= 0 && textToFind[charToFind] == textToSearch[charToFind+i])
                {
                    charToFind--;
                }
                if(charToFind < 0)
                {
                    yield return new SearchResult(i, textToFind.Length);
                    i += textToFind.Length;
                }
                else
                {
                    if (map.ContainsKey(textToSearch[i + textToFind.Length - 1]))
                    {
                        i += map[textToSearch[i + textToFind.Length - 1]];
                    }
                    else
                    {
                        i += defaultSkipLength;
                    }
                }
            }
		}






		public IEnumerable<SearchResult> Search(string textToSearch, string textToFind)
        {
            if (textToSearch.Length < textToFind.Length) yield break;

            for (var i = 0; i < textToSearch.Length; i++)
            {
                var searchLength = 0;
                while (searchLength < textToFind.Length)
                {
                    if (textToSearch[i + searchLength] != textToFind[searchLength])
                    {
                        i += searchLength;
                        break;
                    }
                    searchLength++;
                }
                if (searchLength == textToFind.Length)
                {
                    yield return new SearchResult(i, textToFind.Length);
                    i += textToFind.Length;
                }
            }
        }
    }
}
