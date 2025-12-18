namespace Homework_2
{
    public class SpaceCounter
    {
        public Task<int> GetSpaces(string row)
        {
            int result = 0;

            foreach (char s in row)
                if (s == ' ')
                    result++;

            return Task.FromResult(result);
        }
    }
}
