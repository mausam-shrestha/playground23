namespace Playground.Core.Services
{
    public class Validator : IValidator
    {
        private readonly int _minimumInput;
        private readonly int _maximumInput;

        public Validator(int minimumInput, int maximumInput)
        {
            _minimumInput = minimumInput;
            _maximumInput = maximumInput;
        }

        public bool IsValid()
        {
            return (_minimumInput > 0 && _maximumInput > 0);
        }
    }
}
