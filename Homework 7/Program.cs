namespace Homework_7
{
    public class Program
    {
        static void Main(string[] args)
        {
            GetMaxTest.StartTest();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Введите путь к папке с файлами:");
            var path = Console.ReadLine();
            EnumerationFilesTest.StartTest(path!);
        }
    }
}
