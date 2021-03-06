﻿using System;
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
                if (isStrike(rollNum))
                {
                    score += 10 + strikeBonus(rollNum);
                    rollNum += 1;
                }
                else if (isSpare(rollNum))
                {
                    score += 10 + spareBonus(rollNum);
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

        public bool isStrike(int rollNum)
        {
            return (rolls[rollNum] == 10);
        }

        public int strikeBonus(int rollNum)
        {
            return rolls[rollNum + 1] + rolls[rollNum + 2];
        }

        public int spareBonus(int rollNum)
        {
            return rolls[rollNum + 2];
        }
    }
}
