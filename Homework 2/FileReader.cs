namespace Homework_2
{
    public class FileReader
    {
        public async Task<int> GetSpacesAsyncFromFile(string filePath)
        {
            int result = 0;
            SpaceCounter spaceCounter = new SpaceCounter();
            List<Task<int>> tasks = new List<Task<int>>();

            using (var sr = new StreamReader(filePath))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();

                    if (line != null)
                        tasks.Add(Task.Run(() => spaceCounter.GetSpaces(line)));
                }
            }

            await Task.WhenAll(tasks);

            foreach (var task in tasks)
                result += task.Result;

            return result;
        }
    }
}
