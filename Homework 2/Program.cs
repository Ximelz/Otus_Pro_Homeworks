namespace Homework_2
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            string dirPath = "";

            List<Task> tasks = new List<Task>();

            DirectoryReader dirRead = new DirectoryReader();

            tasks.Add(Task.Run(() => dirRead.GetSpacesFromFilesAsyncInDirecrory(dirPath)));

            await Task.WhenAll(tasks);
        }
    }
}
