using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Homework_3
{
    public class IntArraySummator
    {
        public static void Start(int[] intArray, ISummator summator)
        {
            Console.WriteLine($"Тип сумматора: {summator.GetType()}.");
            var sw = Stopwatch.StartNew();
            var sum = summator.GetSumm(intArray);
            sw.Stop();
            Console.WriteLine($"Время выполнения:{sw.Elapsed.TotalMilliseconds} мс, вычисленная сумма:{sum}.");
            Console.WriteLine("------------------------------------------------");
        }
    }
}
