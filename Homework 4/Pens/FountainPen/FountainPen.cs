namespace Homework_4
{
    /// <summary>
    /// Перьевая ручка.
    /// </summary>
    public class FountainPen : Pen, IMyCloneable<FountainPen>, ICloneable
    {
        public FountainPen(double penLength, string penColor, Ink ink, FountainPenSize tickness) : base(penLength, penColor)
        {
            this.ink = ink;
            this.tickness = tickness;
        }

        /// <summary>
        /// Чернила перьевой ручки.
        /// </summary>
        public Ink ink { get; private set; }

        /// <summary>
        /// Толщина пера.
        /// </summary>
        public FountainPenSize tickness { get; private set; }

        #region Методы клонирования
        public override FountainPen MyClone() => new FountainPen(this.length, this.color, ink.MyClone(), this.tickness);
        public override object Clone() => MyClone();
        #endregion

        #region Переопределение вывода класса в строку
        public override string ToString() => $"Тип ручки: перьевая ручка.\r\nТолщина пера: {tickness.GetString()}\r\n{base.ToString()}{ink}";
        #endregion

        #region Переопределение метода сравнения данного объекта
        public override bool Equals(object obj)
        {
            if (obj is FountainPen other)
                return ink.Equals(other.ink) && base.Equals(other) && tickness == other.tickness;

            return false;
        }
        public override int GetHashCode() => HashCode.Combine(base.GetHashCode(), ink.GetHashCode(), tickness);
        #endregion
    }
}
