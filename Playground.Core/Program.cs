using Playground.Core.Services;

IFizzBuzzGame fizzBuzzGame = new FizzBuzzGame();
IGameLogger gameLogger = new GameLogger();
(int minimumInput, int maximumInput) range = (1, 100);

IValidator validator = new Validator(range.minimumInput, range.maximumInput);

if (!validator.IsValid())
{
    Console.WriteLine("Input validation failed. Please check your input range.");
    return;
}

IGame game = new Game(fizzBuzzGame, range, gameLogger);

game.Run();