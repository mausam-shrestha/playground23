using Playground.Core.Services;

IFizzBuzzGame fizzBuzzGame = new FizzBuzzGame();
IGameLogger gameLogger = new GameLogger();

IGame game = new Game(fizzBuzzGame, gameLogger);

game.Execute();