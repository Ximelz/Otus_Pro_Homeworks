using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_3
{
    public interface ISummator
    {
        /// <summary>
        /// Получение типа сумматора.
        /// </summary>
        /// <returns>Тип сумматора.</returns>
        string GetType();
        /// <summary>
        /// Метод для суммирования элементов массива.
        /// </summary>
        /// <param name="intArray">Массив чисел.</param>
        /// <returns>Сумма чисел в массиве.</returns>
        long GetSumm(int[] intArray);
    }
}
