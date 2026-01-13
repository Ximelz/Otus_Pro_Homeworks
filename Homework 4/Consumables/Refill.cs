namespace Homework_4
{
    /// <summary>
    /// Стержень.
    /// </summary>
    public class Refill : Consumables, IMyCloneable<Refill>
    {
        public Refill(string Color, double PointSize) : base(Color) => this.PointSize = PointSize;

        /// <summary>
        /// Толщина линии стержня.
        /// </summary>
        public double PointSize { get; private set; }

        #region Методы клонирования
        public override Refill MyClone() => new Refill(this.Color, this.PointSize);
        #endregion

        #region Переопределение вывода класса в строку
        public override string ToString() => $"Тип расходника: стержень ручки.\r\nТолщина линии: {PointSize} мм.\r\n{base.ToString()}";
        #endregion

        #region Переопределение метода сравнения данного объекта
        public override bool Equals(object obj)
        {
            if (obj is Refill other)
                return PointSize == other.PointSize && base.Equals(other);

            return false;
        }
        public override int GetHashCode() => HashCode.Combine(base.GetHashCode(), PointSize);
        #endregion
    }
}
