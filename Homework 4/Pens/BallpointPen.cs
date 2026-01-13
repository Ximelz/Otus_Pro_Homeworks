namespace Homework_4
{
    /// <summary>
    /// Шариковая ручка.
    /// </summary>
    public class BallpointPen : Pen, IMyCloneable<BallpointPen>, ICloneable
    {
        public BallpointPen(double PenLength, string PenColor, Refill PenRefill) : base(PenLength, PenColor) => this.PenRefill = PenRefill;

        /// <summary>
        /// Стержень ручки.
        /// </summary>
        public Refill PenRefill { get; private set; }

        #region Методы клонирования
        public override BallpointPen MyClone() => new BallpointPen(this.Length, this.Color, PenRefill.MyClone());
        public override object Clone() => MyClone();
        #endregion

        #region Переопределение вывода класса в строку
        public override string ToString() => $"Тип ручки: шариковая ручка.\r\n{base.ToString()}{PenRefill}";
        #endregion

        #region Переопределение метода сравнения данного объекта
        public override bool Equals(object obj)
        {
            if (obj is BallpointPen other)
                return PenRefill.Equals(other.PenRefill) && base.Equals(other);

            return false;
        }
        public override int GetHashCode() => HashCode.Combine(base.GetHashCode(), PenRefill.GetHashCode());
        #endregion
    }
}
