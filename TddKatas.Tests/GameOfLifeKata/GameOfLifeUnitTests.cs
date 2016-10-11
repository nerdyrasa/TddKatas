using System;
using Xunit;

// When a bug pops up in your code, first thing to do is to write a failing test for it.

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

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        public void DeadCell_WithFewerThan3LiveNeighbors_StaysDead(int liveNeighbors)
        {
            var currentState = CellState.Dead;
            CellState newState = LifeRules.GetNewState(currentState, liveNeighbors);
            Assert.Equal(CellState.Dead, newState);
        }

        [Theory]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        public void DeadCell_WithMoreThan3LiveNeighbors_StaysDead(int liveNeighbors)
        {
            var currentState = CellState.Dead;
            CellState newState = LifeRules.GetNewState(currentState, liveNeighbors);
            Assert.Equal(CellState.Dead, newState);
        }

        //https://www.richard-banks.org/2015/07/stop-using-assertthrows-in-your-bdd.html


        // This test case expects an argument out of range exception for the currentState parameter
        // How do I know the right argument out of range exception was thrown?

        // xUnit does not have an ExpectedException Attribute like NUnit 2.2 and MSTest

        [Fact]
        public void CurrentState_When2_ThrowsArgumentException()
        {
            var currentState = (CellState)2;
            int liveNeighbors = 2;

            var exception = Record.Exception(() => LifeRules.GetNewState(currentState, liveNeighbors));
            Assert.NotNull(exception);
            Assert.IsType<ArgumentOutOfRangeException>(exception);
        }

        // This test case expects an argument out of range exception for the liveNeighbors argument
        // How do I know the right argument out of range exception was thrown?
        // The following test explicitly tests that the right argument out fo range 
        // exception is thrown.

        [Fact]
        public void LiveNeighbors_MoreThan8_ThrowsArgumentException()
        {
            var currentState = CellState.Alive;
            int liveNeighbors = 9;
            var paramName = "liveNeighbors";

            try
            {
                LifeRules.GetNewState(currentState, liveNeighbors);

                // This is the xUnit alternative to nUnit's Assert.Fail
                // http://xunit.github.io/docs/comparisons.html#attributes

                Assert.True(false, "Exception was not thrown.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Assert.Equal(paramName, ex.ParamName);
            }
        }

        [Fact]
        public void LiveNeighbors_LessThan0_ThrowsArgumentException()
        {
            var currentState = CellState.Alive;
            int liveNeighbors = -1;
            var paramName = "liveNeighbors";

            Assert.Throws<ArgumentOutOfRangeException>(
                paramName,
                () => LifeRules.GetNewState(currentState, liveNeighbors));
        }
    }
}
