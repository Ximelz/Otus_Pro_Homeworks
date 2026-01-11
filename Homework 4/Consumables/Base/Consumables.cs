namespace Homework_4
{
    /// <summary>
    /// Расходники письменных принадлежностей.
    /// </summary>
    public class Consumables : IMyCloneable<Consumables>, ICloneable
    {
        public Consumables(string color) => this.color = color;

        /// <summary>
        /// Цвет расходников.
        /// </summary>
        public string color { get; private set; }

        #region Методы клонирования
        public virtual object Clone() => MyClone();
        public virtual Consumables MyClone() => new Consumables(this.color);
        #endregion

        #region Переопределение вывода класса в строку
        public override string ToString() => $"Цвет расходника: {color}\r\n";
        #endregion

        #region Переопределение метода сравнения данного объекта
        public override bool Equals(object obj)
        {
            if (obj is Consumables other)
                return color == other.color;

            return false;
        }

        public override int GetHashCode() => HashCode.Combine(color);
        #endregion
    }
}
