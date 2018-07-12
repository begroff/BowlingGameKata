using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingGame;

namespace BowlingGameTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_GutterGame()
        {
            Game g = new Game();

            for (int i = 0; i < 20; i++)
            {
                g.roll(0);
                Assert.AreEqual(0, g.score());
            }
        }
    }
}
