using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddKatas
{
    public class Game
    {
        private int score = 0;

        private int[] rolls = new int[21];

        private int currentRoll = 0;

        public void roll(int pins)
        {
            rolls[currentRoll] = pins;
            currentRoll++;
        }

        public int scoreGame()
        {
            int score = 0;

            int rollNum = 0;

            for (int frame = 0; frame < 10; frame++)
            {

                if (rolls[rollNum] + rolls[rollNum + 1] == 10) // spare
                {
                    score += 10 + rolls[rollNum + 2];
                }
                else
                {
                    score += rolls[rollNum] + rolls[rollNum + 1];
                }

                rollNum += 2;
            }

            return score;
        }
    }
}
