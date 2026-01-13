using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Homework_3
{
    public class ParallelSummator : ISummator
    {
        public long GetSumm(int[] intArray)
        {
            int cores = Environment.ProcessorCount;
            List<int[]> arrays = ArrayFragmentation(intArray, cores);
            List<Thread> threads = new List<Thread>();
            object lockObj = new();
            int result = 0;

            foreach (int[] array in arrays)
            {
                Thread thread = new(() =>
                                         {
                                             lock (lockObj)
                                             {
                                                 result += array.Sum();
                                             }
                                          });
                threads.Add(thread);
                thread.Start();
            }

            foreach (Thread t in threads) t.Join();
            return result;
        }

        private List<int[]> ArrayFragmentation(int[] array, int count)
        {
            List<int[]> result = new List<int[]>();
            int arraysCount = array.Length / count;
            int currentIndex = 0;

            for (int i = 0; i < count - 1; i++)
            {
                result.Add(array.Skip(currentIndex).Take(arraysCount).ToArray());
                currentIndex += arraysCount;
            }
            result.Add(array.Skip(currentIndex).ToArray());
            return result;
        }

        string ISummator.GetType() => "Параллельный сумматор";
    }
}
