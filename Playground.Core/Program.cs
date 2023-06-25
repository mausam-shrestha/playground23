using Playground.Core.Services;

IFizzBuzzGame fizzBuzzGame = new FizzBuzzGame();

Game game = new(fizzBuzzGame);

game.Execute();
