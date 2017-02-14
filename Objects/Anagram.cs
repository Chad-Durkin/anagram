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

        public void AnagramWordSort()
        {
            char[] anagramSort = new char[_anagramWord.Length];

            anagramSort = _anagramWord.ToCharArray();

            Array.Sort(anagramSort);
            Console.WriteLine(anagramSort);

            string anagram = new string(anagramSort);

            for(var index = 0; index < _checkWords.Length; index++)
            {
                char[] anagramCheckSort = _checkWords[index].ToCharArray();
                Array.Sort(anagramCheckSort);
                string newAnagramCheckSort = new string(anagramCheckSort);
                if (newAnagramCheckSort == anagram)
                {
                    _anagramWordSort.Add(_checkWords[index]);
                }
            }
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
