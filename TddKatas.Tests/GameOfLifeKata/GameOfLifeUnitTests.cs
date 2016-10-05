using Xunit;

namespace TddKatas.Tests
{
    public class GameOfLifeUnitTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        public void LiveCell_FewerThan2LiveNeighbors_Dies(int liveNeighbors)
        {
            var currentState = CellState.Alive;

            CellState newState = LifeRules.GetNewState(currentState, liveNeighbors);

            Assert.Equal(CellState.Dead, newState);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        public void LiveCell_2Or3LiveNeighbors_Lives(int liveNeighbors)
        {
            var currentState = CellState.Alive;

            CellState newState = LifeRules.GetNewState(currentState, liveNeighbors);

            Assert.Equal(CellState.Alive, newState);
        }

        [Theory]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        public void LiveCell_MoreThan3LiveNeighbors_Dies(int liveNeighbors)
        {
            var currentState = CellState.Alive;

            CellState newState = LifeRules.GetNewState(currentState, liveNeighbors);

            Assert.Equal(CellState.Dead, newState);
        }

        [Fact]
        public void DeadCell_With3LiveNeighbors_BecomesAlive()
        {
            var liveNeighbors = 3;
            var currentState = CellState.Dead;

            CellState newState = LifeRules.GetNewState(currentState, liveNeighbors);

            Assert.Equal(CellState.Alive, newState);

        }
    }
}
