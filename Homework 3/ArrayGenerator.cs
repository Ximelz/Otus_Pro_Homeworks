using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_3
{
    public static class ArrayGenerator
    {
        /// <summary>
        /// Создание массива случайных чисел.
        /// </summary>
        /// <param name="n">Размер массива.</param>
        /// <returns>Массив случайных чисел.</returns>
        public static int[] Generate(int n)
        {
            Random random = new Random();
            int[] array = new int[n];
            
            for(int i = 0; i < n; i++)
                array[i] = random.Next(0, 100);

            return array;
        }
    }
}
