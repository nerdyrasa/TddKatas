using Xunit;

namespace TddKatas.Tests
{
    public class FizzBuzzerUnitTests
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(11)]
        [InlineData(13)]
        [InlineData(14)]
        public void Buzzer_WhenDefault_ReturnsInputAsString(int input)
        {
            // Act
            string output = FizzBuzzer.GetValue(input);

            // Assert
            Assert.Equal(input.ToString(), output);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(12)]
        public void Buzzer_WhenDivBy3_ReturnsFizz(int input)
        {
            // Act
            string output = FizzBuzzer.GetValue(input);

            // Assert
            Assert.Equal("Fizz", output);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        public void Buzzer_WhenDivBy5_ReturnsBuzz(int input)
        {
            // Act
            string output = FizzBuzzer.GetValue(input);

            // Assert
            Assert.Equal("Buzz", output);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(45)]
        public void Buzzer_WhenDivBy3andDivBy5_ReturnsFizzBuzz(int input)
        {
            // Act
            string output = FizzBuzzer.GetValue(input);

            // Assert
            Assert.Equal("FizzBuzz", output);
        }
    }
}
