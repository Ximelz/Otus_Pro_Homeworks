namespace Homework_5
{
    public class RangeNatureNumbs
    {
        /// <summary>
        /// Нижняя граница диапазона.
        /// </summary>
        public int min { get; set; }

        /// <summary>
        /// Верхняя граница диапазона.
        /// </summary>
        public int max { get; set; }

        /// <summary>
        /// Проверка числа на вхождение в текущий диапазон.
        /// </summary>
        /// <param name="numb">Проверяемое число.</param>
        /// <returns>Результат вхождения данного числа.</returns>
        public bool NumbInRange(int numb)
        {
            if (min > numb)
                return false;

            if (max < numb)
                return false;

            return true;
        }

        public virtual void SetRange(int firstLimit, int secondLimit)
        {
            if (firstLimit > secondLimit)
            {
                min = secondLimit;
                max = firstLimit;
                return;
            }

            if (firstLimit < 1)
                min = 1;

            if (secondLimit < 1)
                max = 1;

            min = firstLimit;
            max = secondLimit;
        }
    }
}
