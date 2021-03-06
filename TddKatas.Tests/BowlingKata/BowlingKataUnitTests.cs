﻿using Xunit;

namespace TddKatas.Tests
{
    public class BowlingKataUnitTests
    {
        private Game g;

        public BowlingKataUnitTests()
        {
            g = new Game();
        }

        [Fact]
        public void DoesGameExist()
        {
            //arrange

            //act

            //assert
            Assert.NotNull(g);
        }

        [Fact]
        public void GutterGameReturns0()
        {
            //arrange       
            int pins = 0;
            int rolls = 20;

            //act
            rollMany(rolls, pins);

            //assert
            Assert.Equal(0, g.scoreGame());

        }

        [Fact]
        public void SinglePinForEveryRollReturns20()
        {
            //arrange
            int pins = 1;
            int rolls = 20;

            //act
            rollMany(rolls, pins);

            //assert
            Assert.Equal(20, g.scoreGame());
        }

        [Fact]
        public void SpareFrameWithRolls5and5and3Returns16()
        {
            //arrange
            g.roll(5);
            g.roll(5);
            g.roll(3);

            int remainingRolls = 17;
            int pins = 0;

            //act
            rollMany(remainingRolls, pins);

            //assert
            Assert.Equal(16, g.scoreGame());
        }

        [Fact]
        public void OneStrikeFollowedByRoll3Roll4Returns24()
        {
            //arrange
            g.roll(10); // When you roll a strike you are done for the frame.

            g.roll(3);
            g.roll(4);

            int remainingRolls = 16;
            int pins = 0;

            //act
            rollMany(remainingRolls, pins);

            //assert
            Assert.Equal(24, g.scoreGame());
        }

        [Fact]
        public void AllStrikesReturns300()
        {

            int rolls = 12;
            int pins = 10;

            //act
            rollMany(rolls, pins);

            //assert
            Assert.Equal(300, g.scoreGame());
        }


        public void rollMany(int rolls, int pins)
        {
            for (int i = 0; i < rolls; i++)
            {
                g.roll(pins);
            }
        }
    }
}
