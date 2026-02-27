namespace Homework_7
{
    public class EnumerationFilesTest
    {
        public static void StartTest(string path)
        {
            try
            {
                EnumerationFiles getFiles = new EnumerationFiles();
                getFiles.FileFound += SendMessage;
                getFiles.StartEnumeration(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Перебор файлов завершен");
            }
        }
        public static int SendMessage(FileArgs e)
        {
            Console.WriteLine($"File: {e.fileName}");
            Console.WriteLine("Введите \"Stop\" для завершения перебора:");
            var input = Console.ReadLine();
            if (input == "Stop")
                return 1;
            return 0;
        }
    }
}
