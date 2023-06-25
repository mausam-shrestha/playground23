using Playground.Core.Services;

IFizzBuzzGame fizzBuzzGame = new FizzBuzzGame();

IGame game = new Game(fizzBuzzGame);

game.Execute();