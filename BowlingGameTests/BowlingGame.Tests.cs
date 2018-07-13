using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingGame;

namespace BowlingGameTests
{
    [TestClass]
    public class UnitTest1
    {
        private Game g;

        [TestInitialize]
        public void TestSetup() {
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
        public void Test_AllOnes() {
            rollMany(20, 1);
            Assert.AreEqual(20, g.score());
        }
    }
}
