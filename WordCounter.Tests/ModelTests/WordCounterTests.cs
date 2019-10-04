using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Counter.Models;

namespace Counter.Tests
{
    [TestClass]
    public class TestSentence
    {
        [TestMethod]
        public void WordCounter_ClassIsCreated_true()
        {
            WordCounter newWordCounter = new WordCounter("He is as pleased as a dog with two tails.", "pleased");
            Assert.AreEqual(typeof(WordCounter), newWordCounter.GetType());
        }
        [TestMethod]
        public void InputtedSentence_StoredInputtedSentence_String()
        {
            WordCounter newWordCounter = new WordCounter("He is as slow as molasses in January.", "molasses");
               string testWord = newWordCounter.InputtedWord;
               Assert.AreEqual("molasses", testWord);
        }

        [TestMethod]
        public void InputtedSentence_InputtedSentenceToLower_true()
        {
            WordCounter newWordCounter = new WordCounter("His voice sounded like someone forgot to grease the wagon.", "grease");
            string lowerInputtedSentence = newWordCounter.InputtedSentence;
            Assert.AreEqual("his voice sounded like someone forgot to grease the wagon.", lowerInputtedSentence);

        }
        [TestMethod]
        public void InputtedWord_InputtedWordToLower_true()
        {
            WordCounter newWordCounter = new WordCounter("He didn’t have manners enough to carry guts to a bear.", "GUTS");
            string lowerInputtedWord = newWordCounter.InputtedWord;
            Assert.AreEqual("guts", lowerInputtedWord);
        }
        [TestMethod]
        public void InputtedSentenceArray_InputtedSentenceArrayIsArray_true()
        {
            WordCounter newWordCounter = new WordCounter("He had been in the desert so long, he knew all the lizards by their first names.", "lizards");
            string[] testArray = newWordCounter.InputtedSentenceArray;
            Assert.AreEqual("desert", testArray[5]);
        }
    }
}