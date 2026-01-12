namespace Homework_5
{
    public interface IGetSettingsRepository
    {
        /// <summary>
        /// Метод для получения количества попыток для отгадывания.
        /// </summary>
        /// <param name="amount">Количество попыток</param>
        Task<int> GetAmountTries();

        /// <summary>
        /// Метод для получения диапазона чисел для отгадывания.
        /// </summary>
        /// <param name="min">Нижняя граница диапазона.</param>
        /// <param name="max">Верхняя граница диапазона.</param>
        Task<RangeNatureNumbs> GetRangeNumbs();
    }
}
