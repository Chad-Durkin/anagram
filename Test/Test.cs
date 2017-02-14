using Xunit;
using System;
using System.Collections.Generic;
using AnagramApp.Objects;

namespace AnagramAppTest
{
    public class AnagramAppTest
    {
        [Fact]
        public void WordListMaker_ListConstruction_InputtedList()
        {
            // Arrange
            string anagramWord = "neo";
            string listWords = "one, two, three";
            string[] output = new string[] {"one", "two", "three"};
            // Act
            Anagram newAnagram = new Anagram(anagramWord, listWords);
            // Assert
            Assert.Equal(output[0], newAnagram.GetCheckWords()[0]);
        }

        [Fact]
        public void AnagramConstructor_AnagramWordAssignment_Word()
        {
            // Arrange
            string anagramWord = "neo";
            string listWords = "one, two, three";
            string[] output = new string[] {"one", "two", "three"};
            // Act
            Anagram newAnagram = new Anagram(anagramWord, listWords);
            // Assert
            Assert.Equal(anagramWord, newAnagram.GetAnagramWord());
        }

        [Fact]
        public void AnagramWordSort_CheckingForPossibleAnagrams()
        {
            // Arrange
            string anagramWord = "neo";
            string listWords = "one, two, three";
            List<string> output = new List<string> {"one"};
            // Act
            Anagram newAnagram = new Anagram(anagramWord, listWords);
            newAnagram.AnagramWordSort();
            // Assert
            Assert.Equal(output[0], newAnagram.GetAnagramWordSort()[0]);
        }
    }
}
