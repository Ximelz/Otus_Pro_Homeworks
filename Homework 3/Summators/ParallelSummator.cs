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
            Thread[] threads = new Thread[cores];
            object lockObj = new();
            int result = 0;
            int chunkSize = intArray.Length / cores;

            for (int i = 0; i < cores; i++)
            {
                int currentIndex = i * chunkSize;
                int end = (i == cores - 1) ? intArray.Length : currentIndex + chunkSize;

                threads[i] = new(() =>
                {
                    int tempSumm = 0;

                    for (int j = currentIndex; j < end; j++)
                        tempSumm += intArray[j];

                    lock (lockObj)
                        result += tempSumm;
                });

                threads[i].Start();
            }

            foreach (Thread t in threads) t.Join();
            return result;
        }

        string ISummator.GetType() => "Параллельный сумматор";
    }
}
