namespace Playground.Core.Services
{
    public class Game : IGame
    {
        private readonly IFizzBuzzGame _fizzBuzzGame;
        private readonly (int minimum, int maximum) _inputRange;
        private readonly IGameLogger _gameLogger;

        public Game(IFizzBuzzGame fizzBuzzGame,
                    (int, int) inputRange,
                    IGameLogger gameLogger)
        {
            _fizzBuzzGame = fizzBuzzGame;
            _inputRange = inputRange;
            _gameLogger = gameLogger;
        }

        public void Run()
        {
            var inputNumbers = Enumerable.Range(_inputRange.minimum, _inputRange.maximum)
                                         .Select(x => (uint)x);

            inputNumbers.ToList().ForEach(currentInput =>
            {
                string gameOutput = _fizzBuzzGame.GetOutput(currentInput);

                _gameLogger.Log(currentInput, gameOutput);
            });
        }
    }
}
