namespace Homework_4
{
    /// <summary>
    /// Стержень.
    /// </summary>
    public class Refill : Consumables, IMyCloneable<Refill>, ICloneable
    {
        public Refill(string color, double pointSize) : base(color) => this.pointSize = pointSize;

        /// <summary>
        /// Толщина линии стержня.
        /// </summary>
        public double pointSize { get; private set; }

        #region Методы клонирования
        public override Refill MyClone() => new Refill(this.color, this.pointSize);
        public override object Clone() => MyClone();
        #endregion

        #region Переопределение вывода класса в строку
        public override string ToString() => $"Тип расходника: стержень ручки.\r\nТолщина линии: {pointSize} мм.\r\n{base.ToString()}";
        #endregion

        #region Переопределение метода сравнения данного объекта
        public override bool Equals(object obj)
        {
            if (obj is Refill other)
                return pointSize == other.pointSize && base.Equals(other);

            return false;
        }
        public override int GetHashCode() => HashCode.Combine(base.GetHashCode(), pointSize);
        #endregion
    }
}
