using System.Diagnostics;
using Playground.Core.Services;

namespace Playground.UnitTests
{
    [TestClass]
    public class FizzBuzzGameTests
    {
        private readonly IFizzBuzzGame _sut;

        public FizzBuzzGameTests()
        {
            _sut = new FizzBuzzGame();
        }

        [TestMethod]
        [DataRow("1", "1", DisplayName = "Minimum input")]
        [DataRow("100", "Buzz", DisplayName = "Maximum input")]
        [DataRow("3", "Fizz", DisplayName = "Returns Fizz")]
        [DataRow("5", "Buzz", DisplayName = "Returns Buzz")]
        [DataRow("15", "FizzBuzz", DisplayName = "Returns FizzBuzz")]
        [DataRow("2", "2", DisplayName = "Returns back the input")]
        public void Given_Inputs_From_Player_When_It_Is_Valid_Then_Display_Expected_Output(string rawInput, string expectedOutput)
        {
            // Arrange
            if (!uint.TryParse(rawInput, out uint playerInput))
            {
                Debug.WriteLine("Invalid test parameter.");
            }

            // Act
            var actualOutput = _sut.GetOutput(playerInput);

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}