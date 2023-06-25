namespace Playground.Core.Services
{
    public class FizzBuzzGame : IFizzBuzzGame
    {
        public string GetOutput(uint input)
        {
            if (input % 15 == 0)
            {
                return "FizzBuzz";
            }

            if (input % 3 == 0)
            {
                return "Fizz";
            }

            if (input % 5 == 0)
            {
                return "Buzz";
            }

            return input.ToString();
        }
    }
}
