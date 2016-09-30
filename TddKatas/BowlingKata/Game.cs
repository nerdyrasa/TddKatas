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

                if (rolls[rollNum] == 10)  // is strike
                {
                    score += rolls[rollNum] + rolls[rollNum + 1] + rolls[rollNum + 2];
                    rollNum += 1;
                }
                if (isSpare(rollNum))
                {
                    score += 10 + rolls[rollNum + 2];
                    rollNum += 2;
                }
                else
                {
                    score += rolls[rollNum] + rolls[rollNum + 1];
                    rollNum += 2;
                }


            }

            return score;
        }

        public bool isSpare(int rollNum)
        {
            return (rolls[rollNum] + rolls[rollNum + 1] == 10);
        }
    }
}
