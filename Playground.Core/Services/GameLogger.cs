namespace Playground.Core.Services
{
    public class GameLogger : IGameLogger
    {
        public void Log(uint input, string output)
        {
            Console.WriteLine($"For {input} > Output is > {output}");

            Console.WriteLine(Environment.NewLine);
        }
    }
}
