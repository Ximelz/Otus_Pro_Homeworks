namespace Homework_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = ArrayGenerator.Generate(100_000);
            int[] secondArray = ArrayGenerator.Generate(1_000_000);
            int[] thirdArray = ArrayGenerator.Generate(10_000_000);

            Console.WriteLine($"Размер массива {firstArray.Length}\r\n");
            IntArraySummator.Start(firstArray, new DefaultSummator());
            IntArraySummator.Start(firstArray, new ParallelSummator());
            IntArraySummator.Start(firstArray, new PLINQSummator());


            Console.WriteLine($"\r\nРазмер массива {firstArray.Length}\r\n");
            IntArraySummator.Start(secondArray, new DefaultSummator());
            IntArraySummator.Start(secondArray, new ParallelSummator());
            IntArraySummator.Start(secondArray, new PLINQSummator());


            Console.WriteLine($"\r\nРазмер массива {firstArray.Length}\r\n");
            IntArraySummator.Start(thirdArray, new DefaultSummator());
            IntArraySummator.Start(thirdArray, new ParallelSummator());
            IntArraySummator.Start(thirdArray, new PLINQSummator());

            Console.ReadKey();
        }
    }
}
