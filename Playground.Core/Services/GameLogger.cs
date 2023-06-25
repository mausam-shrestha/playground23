namespace Playground.Core.Services
{
    public class GameLogger : IGameLogger
    {
        public void Log(int input, string output)
        {
            Console.WriteLine($"For {input} > Output is > {output}");

            Console.WriteLine(Environment.NewLine);
        }
    }
}
