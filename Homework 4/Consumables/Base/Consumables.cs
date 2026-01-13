namespace Homework_4
{
    /// <summary>
    /// Расходники письменных принадлежностей.
    /// </summary>
    public class Consumables : IMyCloneable<Consumables>, ICloneable
    {
        public Consumables(string Color) => this.Color = Color;

        /// <summary>
        /// Цвет расходников.
        /// </summary>
        public string Color { get; private set; }

        #region Методы клонирования
        public virtual object Clone() => MyClone();
        public virtual Consumables MyClone() => new Consumables(this.Color);
        #endregion

        #region Переопределение вывода класса в строку
        public override string ToString() => $"Цвет расходника: {Color}\r\n";
        #endregion

        #region Переопределение метода сравнения данного объекта
        public override bool Equals(object obj)
        {
            if (obj is Consumables other)
                return Color == other.Color;

            return false;
        }

        public override int GetHashCode() => HashCode.Combine(Color);
        #endregion
    }
}
