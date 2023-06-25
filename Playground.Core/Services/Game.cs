namespace Playground.Core.Services
{
    public class Game
    {
        private readonly IEnumerable<uint> _inputNumbers;
        private readonly IFizzBuzzGame _fizzBuzzGame;

        public Game(IFizzBuzzGame fizzBuzzGame)
        {
            _fizzBuzzGame = fizzBuzzGame;
            _inputNumbers = Enumerable.Range(1, 100).Select(x => (uint)x);
        }

        public void Execute()
        {
            _inputNumbers.ToList().ForEach(currentInput =>
            {
                Console.WriteLine($"For {currentInput} > Output is > {_fizzBuzzGame.GetOutput(currentInput)}{Environment.NewLine}");
            });
        }
    }
}
