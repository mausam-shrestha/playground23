namespace Playground.Core.Services
{
    public class Game : IGame
    {
        private readonly IEnumerable<uint> _inputNumbers;
        private readonly IFizzBuzzGame _fizzBuzzGame;
        private readonly IGameLogger _gameLogger;

        public Game(IFizzBuzzGame fizzBuzzGame, IGameLogger gameLogger)
        {
            _fizzBuzzGame = fizzBuzzGame;
            _gameLogger = gameLogger;
            _inputNumbers = Enumerable.Range(1, 100).Select(x => (uint)x);
        }

        public void Execute()
        {
            _inputNumbers.ToList().ForEach(currentInput =>
            {
                string gameOutput = _fizzBuzzGame.GetOutput(currentInput);

                _gameLogger.Log(currentInput, gameOutput);
            });
        }
    }
}
