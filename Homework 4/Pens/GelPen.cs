namespace Homework_4
{
    /// <summary>
    /// Гелевая ручка.
    /// </summary>
    public class GelPen : Pen, IMyCloneable<GelPen>, ICloneable
    {
        public GelPen(double PenLength, string PenColor, Refill PenRefill) : base(PenLength, PenColor) => this.PenRefill = PenRefill;

        /// <summary>
        /// Стержень ручки.
        /// </summary>
        public Refill PenRefill { get; private set; }

        #region Методы клонирования
        public override GelPen MyClone() => new GelPen(this.Length, this.Color, PenRefill.MyClone());
        public override object Clone() => MyClone();
        #endregion

        #region Переопределение вывода класса в строку
        public override string ToString() => $"Тип ручки: гелевая ручка.\r\n{base.ToString()}{PenRefill}";
        #endregion

        #region Переопределение метода сравнения данного объекта
        public override bool Equals(object obj)
        {
            if (obj is GelPen other)
                return PenRefill.Equals(other.PenRefill) && base.Equals(other);

            return false;
        }
        public override int GetHashCode() => HashCode.Combine(base.GetHashCode(), PenRefill.GetHashCode());
        #endregion
    }
}
