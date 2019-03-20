using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using challenge_3;

namespace testing_challenge3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFailAnswer()
        {
            PuzzleEquation puzzleEquation = new PuzzleEquation();
            string s = puzzleEquation.checkAnswer("-1");
            Assert.AreEqual(s, "Invalid number(must be a number)");
        }

        [TestMethod]
        public void TestCorrectAnswer()
        {
            PuzzleEquation puzzleEquation = new PuzzleEquation();
            puzzleEquation.setPuzzle(3, 3);
            string s = puzzleEquation.checkAnswer("6");
            Assert.AreEqual(s, "correct");
        }

        [TestMethod]
        public void TestInvalidAnswer()
        {
            PuzzleEquation puzzleEquation = new PuzzleEquation();
            string s = puzzleEquation.checkAnswer("abc");
            Assert.AreEqual(s, "Invalid number(must be a number)");
        }
    }

}
