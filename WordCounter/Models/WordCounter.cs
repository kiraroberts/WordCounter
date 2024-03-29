using System;
using System.Collections.Generic;

namespace Counter.Models
{
    public class WordCounter
    {
        public string InputtedSentence { get; set; }
        public string[] InputtedSentenceArray { get; set; }
        public string InputtedWord { get; set; }
        public int NumberOfTimesWordUsed { get; set; }

        public WordCounter(string inputtedSentence, string inputtedWord)
        {
            InputtedSentence = inputtedSentence.ToLower();
            InputtedSentenceArray = InputtedSentence.Split(' ', '.', '!', ',', '?');
            InputtedWord = inputtedWord.ToLower();
            NumberOfTimesWordUsed = NumberOfWordUsed(InputtedSentenceArray, InputtedWord);
        }
        public int NumberOfWordUsed(string[] inputtedSentenceArray, string inputtedWord)
        {
            int number = 0;
            for(int index = 0; index < InputtedSentenceArray.Length; index++)
            {
                if (inputtedWord == InputtedSentenceArray[index])
                {
                    number += 1;
                }
            }
            return number;
        }
    }
}