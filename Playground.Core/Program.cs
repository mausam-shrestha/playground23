using Playground.Core.Services;

IFizzBuzzGame fizzBuzzGame = new FizzBuzzGame();
IGameLogger gameLogger = new GameLogger();
(int minimumInput, int maximumInput) range = (1, 100);

IGame game = new Game(fizzBuzzGame, range, gameLogger);

game.Run();