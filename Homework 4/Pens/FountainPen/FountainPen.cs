namespace Homework_4
{
    /// <summary>
    /// Перьевая ручка.
    /// </summary>
    public class FountainPen : Pen, IMyCloneable<FountainPen>, ICloneable
    {
        public FountainPen(double PenLength, string PenColor, Ink PenInk, FountainPenSize Tickness) : base(PenLength, PenColor)
        {
            this.PenInk = PenInk;
            this.Tickness = Tickness;
        }

        /// <summary>
        /// Чернила перьевой ручки.
        /// </summary>
        public Ink PenInk { get; private set; }

        /// <summary>
        /// Толщина пера.
        /// </summary>
        public FountainPenSize Tickness { get; private set; }

        #region Методы клонирования
        public override FountainPen MyClone() => new FountainPen(this.Length, this.Color, PenInk.MyClone(), this.Tickness);
        public override object Clone() => MyClone();
        #endregion

        #region Переопределение вывода класса в строку
        public override string ToString() => $"Тип ручки: перьевая ручка.\r\nТолщина пера: {Tickness.GetString()}\r\n{base.ToString()}{PenInk}";
        #endregion

        #region Переопределение метода сравнения данного объекта
        public override bool Equals(object obj)
        {
            if (obj is FountainPen other)
                return PenInk.Equals(other.PenInk) && base.Equals(other) && Tickness == other.Tickness;

            return false;
        }
        public override int GetHashCode() => HashCode.Combine(base.GetHashCode(), PenInk.GetHashCode(), Tickness);
        #endregion
    }
}
