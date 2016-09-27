using Xunit;

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

        public void rollMany(int rolls, int pins)
        {
            for (int i = 0; i < rolls; i++)
            {
                g.roll(pins);
            }
        }
    }
}
