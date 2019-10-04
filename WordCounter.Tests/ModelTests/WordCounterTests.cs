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
            WordCounter newWordCounter = new WordCounter("pleased", "He is as pleased as a dog with two tails.");
            Assert.AreEqual(typeof(WordCounter), newWordCounter.GetType());
        }
    }
}