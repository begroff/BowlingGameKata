using System;

namespace BowlingGame
{
    public class Game
    {
        private int gameScore = 0;
        public void roll(int pins)
        {
            gameScore += pins;
        }

        public int score()
        {
            return gameScore;
        }
    }
}
