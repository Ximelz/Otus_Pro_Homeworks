namespace Homework_5
{
    public interface IChecker
    {
        /// <summary>
        /// Метод проверки числа согласно реализованному алгоритму.
        /// </summary>
        /// <param name="number">Проверяемое число.</param>
        /// <returns>Результат проверки.</returns>
        Task<CheckResult> CheckNumb(int number);

        /// <summary>
        /// Метод определения числа для поиска в выбранном диапазоне.
        /// </summary>
        /// <param name="range">Диапазон чисел.</param>
        Task SetHiddenNumb(RangeNatureNumbs range);
    }
}