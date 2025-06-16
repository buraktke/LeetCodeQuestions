using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementTrie
{
    internal class Trie
    {

        string words = "";
        int wordsCount = 0;

        public Trie()
        {

        }
        string currentControl = "";
        public void Insert(string word)
        {
            words += word + "/";
            wordsCount++;
        }

        public bool Search(string word)
        {
            currentControl = words;
            for (int i = 1; i <= wordsCount; i++)
            {
                string currentWord = findCurrentWord();

                if (currentWord == word)
                    return true;

                if (wordsCount > 1)
                    currentControl = removeCurrentWord(currentWord);
            }

            return false;
        }

        public string removeCurrentWord(string currentWord)
        {
            string newWords = "";
            for (int i = currentWord.Length + 1; i < currentControl.Length; i++)
            {
                newWords += currentControl[i];
            }
            return newWords;
        }

        public bool StartsWith(string prefix)
        {
            currentControl = words;
            for (int i = 1; i <= wordsCount; i++)
            {
                string currentWord = findCurrentWord();

                string prefixControl = "";
                for (int j = 0; j < prefix.Length && currentControl.Length > prefix.Length; j++)
                {
                    prefixControl += currentControl[j];
                }


                if (prefix == prefixControl)
                    return true;

                if (wordsCount > 1)
                    currentControl = removeCurrentWord(currentWord);
            }

            return false;
        }

        public string findCurrentWord()
        {
            string currentWord = "";
            for (int j = 0; currentControl[j] != '/'; j++)
                currentWord += currentControl[j];

            return currentWord;
        }
    }
}
