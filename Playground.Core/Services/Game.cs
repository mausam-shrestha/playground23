namespace Playground.Core.Services
{
    public class Game : IGame
    {
        private readonly IFizzBuzzGame _fizzBuzzGame;
        private readonly IGameLogger _gameLogger;
        private readonly (int minimum, int maximum) _inputRange;

        public Game(IFizzBuzzGame fizzBuzzGame,
                    (int, int) inputRange,
                    IGameLogger gameLogger)
        {
            _fizzBuzzGame = fizzBuzzGame;
            _gameLogger = gameLogger;
            _inputRange = inputRange;
        }

        public void Execute()
        {
            var inputNumbers = Enumerable.Range(_inputRange.minimum, _inputRange.maximum).Select(x => (uint)x);

            inputNumbers.ToList().ForEach(currentInput =>
            {
                string gameOutput = _fizzBuzzGame.GetOutput(currentInput);

                _gameLogger.Log(currentInput, gameOutput);
            });
        }
    }
}
