using System;
using System.Collections.Generic;
using System.Text;
namespace Homework_5
{
    public interface ISetSettingsRepository
    {
        /// <summary>
        /// Метод для установки количества попыток для отгадывания.
        /// </summary>
        /// <param name="amount">Количество попыток</param>
        Task SetAmountTries(int amount);

        /// <summary>
        /// Метод для установки диапазона чисел для отгадывания.
        /// </summary>
        /// <param name="range">Диапазон чисел.</param>
        Task SetRangeNumbs(RangeNatureNumbs range);
    }
}
