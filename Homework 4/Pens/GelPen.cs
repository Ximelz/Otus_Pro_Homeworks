namespace Homework_4
{
    /// <summary>
    /// Гелевая ручка.
    /// </summary>
    public class GelPen : Pen, IMyCloneable<GelPen>, ICloneable
    {
        public GelPen(double penLength, string penColor, Refill refill) : base(penLength, penColor) => this.refill = refill;

        /// <summary>
        /// Стержень ручки.
        /// </summary>
        public Refill refill { get; private set; }

        #region Методы клонирования
        public override GelPen MyClone() => new GelPen(this.length, this.color, refill.MyClone());
        public override object Clone() => MyClone();
        #endregion

        #region Переопределение вывода класса в строку
        public override string ToString() => $"Тип ручки: гелевая ручка.\r\n{base.ToString()}{refill}";
        #endregion

        #region Переопределение метода сравнения данного объекта
        public override bool Equals(object obj)
        {
            if (obj is GelPen other)
                return refill.Equals(other.refill) && base.Equals(other);

            return false;
        }
        public override int GetHashCode() => HashCode.Combine(base.GetHashCode(), refill.GetHashCode());
        #endregion
    }
}
