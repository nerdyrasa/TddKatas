using Xunit;

namespace TddKatas.Tests
{
    public class BowlingKataUnitTests
    {
        [Fact]
        public void DoesGameExist()
        {
            Game g = new Game();

            Assert.NotNull(g);
        }

        [Fact]
        public void GutterGameReturns0()
        {
            Game g = new Game();

            int pins = 0;

            for (int i = 0; i < 20; i++)
            {
                g.roll(pins);
            }

            Assert.Equal(0, g.scoreGame());


        }
    }
}
