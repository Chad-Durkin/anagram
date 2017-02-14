using System.Collections.Generic;
using System;

namespace AnagramApp.Objects
{
    public class Anagram
    {
        private string _anagramWord;
        private string[] _checkWords;
        private List<string> _anagramWordSort = new List<string> {};

        public Anagram(string newAnagramWord, string newListWords)
        {
            _anagramWord = newAnagramWord;
            newListWords = newListWords.Replace(" ", string.Empty);
            _checkWords = newListWords.Split(',');
        }

        // public void AnagramWordSort()
        // {
        //     char[] anagramSort = new char[_anagramWord.Length];
        //
        //     anagramSort = _anagramWord.ToCharArray();
        //
        //     Array.Sort(anagramSort);
        //
        //     string anagram = new string(anagramSort);
        //
        //     for(var index = 0; index < _checkWords.Length; index++)
        //     {
        //         char[] anagramCheckSort = _checkWords[index].ToCharArray();
        //         Array.Sort(anagramCheckSort);
        //         string newAnagramCheckSort = new string(anagramCheckSort);
        //         if (newAnagramCheckSort == anagram)
        //         {
        //             _anagramWordSort.Add(_checkWords[index]);
        //         }
        //         else if (newAnagramCheckSort.Contains(anagram))
        //         {
        //             _anagramWordSort.Add(_checkWords[index] + " this word is longer but it does contain the origin word.");
        //         }
        //     }
        // }

        public void AnagramContainsChecker()
        {
            Dictionary<char, int> originDictionary = LetterCounter(_anagramWord);

            for(var index = 0; index < _checkWords.Length; index++)
            {
                bool contains = true;
                Dictionary<char, int> anagramDictionary = LetterCounter(_checkWords[index]);
                foreach(KeyValuePair<char, int> entry in originDictionary)
                {
                    if (anagramDictionary.ContainsKey(entry.Key))
                    {
                        if (entry.Value > anagramDictionary[entry.Key])
                        {
                            contains = false;
                            break;
                        }
                    }
                    else
                    {
                        contains = false;
                        break;
                    }
                }
                if(contains == true)
                {
                    _anagramWordSort.Add(_checkWords[index]);
                }
            }
        }

        public Dictionary<char, int> LetterCounter(string word)
        {
            Dictionary<char, int> newDict = new Dictionary<char, int> {};
            for (int index = 0; index < word.Length; index++)
            {
                if (newDict.ContainsKey(word[index]))
                {
                    newDict[word[index]] += 1;
                }
                else
                {
                    newDict[word[index]] = 1;
                }
            }
            return newDict;
        }

        public string[] GetCheckWords()
        {
            return _checkWords;
        }

        public string GetAnagramWord()
        {
            return _anagramWord;
        }

        public List<string> GetAnagramWordSort()
        {
            return _anagramWordSort;
        }
    }
}
