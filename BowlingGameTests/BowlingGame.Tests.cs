using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingGame;

namespace BowlingGameTests
{
    [TestClass]
    public class UnitTest1
    {
        private Game g;

        [TestInitialize]
        public void TestSetup()
        {
            g = new Game();
        }

        private void rollMany(int n, int pins)
        {
            for (int i = 0; i < n; i++)
            {
                g.roll(pins);
            }
        }

        [TestMethod]
        public void Test_GutterGame()
        {
            rollMany(20, 0);
        }

        [TestMethod]
        public void Test_AllOnes()
        {
            rollMany(20, 1);
            Assert.AreEqual(20, g.score());
        }

        [TestMethod]
        public void Test_OneSpare()
        {
            rollSpare();
            g.roll(3);
            g.roll(5);
            rollMany(17, 0);

            Assert.AreEqual(21, g.score());
        }

        [TestMethod]
        public void Test_OneStrike()
        {
            rollStrike();
            g.roll(3);
            g.roll(4);
            rollMany(16, 0);

            Assert.AreEqual(24, g.score());
        }

        [TestMethod]
        public void Test_PerfectGame()
        {
            rollMany(12, 10);

            Assert.AreEqual(300, g.score());


        }

        private void rollSpare()
        {
            g.roll(5);
            g.roll(5);
        }

        private void rollStrike()
        {
            g.roll(10);
        }
    }
}
