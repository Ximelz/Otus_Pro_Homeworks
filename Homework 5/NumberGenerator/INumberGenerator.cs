namespace Homework_5
{
    public interface INumberGenerator
    {
        /// <summary>
        /// Метод получения случайного числа из указанного диапазона.
        /// </summary>
        /// <param name="range">Диапазон чисел.</param>
        /// <returns>Случайное число.</returns>
        Task<int> GetNumber(RangeNatureNumbs range);
    }
}