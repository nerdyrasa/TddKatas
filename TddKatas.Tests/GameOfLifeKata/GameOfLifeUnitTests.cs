using Xunit;

namespace TddKatas.Tests
{
    public class GameOfLifeUnitTests
    {
        [Fact]
        public void LiveCell_FewerThan2LiveNeighbors_Dies()
        {
            var currentState = CellState.Alive;
            var liveNeighbors = 0;

            CellState newState = LifeRules.GetNewState(currentState, liveNeighbors);

            Assert.Equal(CellState.Dead, newState);
        }
    }
}
