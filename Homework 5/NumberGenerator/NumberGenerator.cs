namespace Homework_5
{
    public class NumberGenerator : INumberGenerator
    {
        public async Task<int> GetNumber(RangeNatureNumbs range)
        {
            Random random = new Random();
            return random.Next(range.min, range.max);
        }
    }
}
