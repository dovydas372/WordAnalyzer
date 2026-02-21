using System;
using System.Collections.Generic;
using System.Text;

namespace WordAnalyzer
{
    internal class CountingWords
    {
      

      
        public Dictionary<string, int> CountWords(string text) {

            var wordsDictionary = new Dictionary<string, int>();
            var words = text.ToLowerInvariant().
                Split( new[] { ' ', '\n', '\r', '\t' },
                       StringSplitOptions.RemoveEmptyEntries
                        );
        
            foreach (var word in words) {

                if (wordsDictionary.ContainsKey(word))
                {
                    wordsDictionary[word] += 1;
                }
                else
                {
                    wordsDictionary.Add(word, 1);
                }
            
            }

            return wordsDictionary;

        }


    }
}





