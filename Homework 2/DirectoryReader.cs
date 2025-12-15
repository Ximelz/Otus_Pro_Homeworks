using System.Diagnostics;

namespace Homework_2
{
    public class DirectoryReader
    {
        public async Task GetSpacesFromFilesAsyncInDirecrory(string path)
        {
            string[] filePaths = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
            int result = 0;
            List<Task<int>> tasks = new List<Task<int>>();
            FileReader fileReader = new FileReader();
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine($"Количество файлов в папке \"{path}\" = {filePaths.Length}");

            stopwatch.Start();

            foreach (string filePath in filePaths)
                tasks.Add(Task.Run(() => fileReader.GetSpacesAsyncFromFile(filePath)));

            await Task.WhenAll(tasks);

            foreach (var task in tasks)
                result += task.Result;

            stopwatch.Stop();

            Console.WriteLine($"Количество пробелов во всех файлах = {result}.\r\n" +
                              $"Общее время выполнения = {stopwatch.Elapsed}");
        }
    }
}
