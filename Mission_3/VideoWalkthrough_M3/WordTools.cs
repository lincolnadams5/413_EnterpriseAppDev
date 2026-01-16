using System;
using System.Collections.Generic;
using System.Text;

namespace VideoWalkthrough_M3
{
    internal class WordTools
    {
        public int WordCounter(string words)
        {
            int wordCount = 0;

            string[] individualWords = words.Split(' ');

            wordCount = individualWords.Length;

            return wordCount;
        }

        public int CharCounter (string words)
        {
            int charCount = 0;

            charCount = words.Length;

            return (charCount);
        }

        public string AlphCounter (string words)
        {
            string resultString = "";
            string w = words.ToLower();
            var hashMap = new Dictionary<char, int>();

            // Loop through the string
            for (int i = 0; i < words.Length; i++)
            {
                char c = words[i];

                if (hashMap.ContainsKey(c))
                {
                    hashMap[c] += 1;
                }
                else
                {
                    hashMap.Add(c, 1);
                }
            }

            foreach (var (key, value) in hashMap)
            {
                resultString += $"{key}: {value}\n";
            }

            return resultString;
        }
    }
}
