using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using challenge_3;

namespace testing_challenge3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            PuzzleEquation puzzleEquation = new PuzzleEquation();
            string s = puzzleEquation.checkAnswer(-1);
            Assert.AreEqual(s, "Invalid number(must be a number)");
        }
    }

}
