namespace Homework_4
{
    /// <summary>
    /// Карандаш.
    /// </summary>
    public class Pencil : IMyCloneable<Pencil>, ICloneable
    {
        public Pencil(double length, string color)
        {
            this.length = length;
            this.color = color;
        }

        /// <summary>
        /// Длина карандаша.
        /// </summary>
        public double length { get; private set; }
        
        /// <summary>
        /// Цвет корпуса карандаша.
        /// </summary>
        public string color { get; private set; }

        #region Методы клонирования
        public virtual object Clone() => MyClone();
        public virtual Pencil MyClone() => new Pencil(this.length, this.color);
        #endregion

        #region Переопределение вывода класса в строку
        public override string ToString() => $"Длина карандаша: {length}.\r\nЦвет карандаша: {color}.\r\n";
        #endregion

        #region Переопределение метода сравнения данного объекта
        public override bool Equals(object obj)
        {
            if (obj is Pencil other)
                return length == other.length && color == other.color;

            return false;
        }
        public override int GetHashCode() => HashCode.Combine(length, color);
        #endregion
    }
}
