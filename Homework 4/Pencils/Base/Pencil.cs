namespace Homework_4
{
    /// <summary>
    /// Карандаш.
    /// </summary>
    public class Pencil : IMyCloneable<Pencil>, ICloneable
    {
        public Pencil(double Length, string Color)
        {
            this.Length = Length;
            this.Color = Color;
        }

        /// <summary>
        /// Длина карандаша.
        /// </summary>
        public double Length { get; private set; }
        
        /// <summary>
        /// Цвет корпуса карандаша.
        /// </summary>
        public string Color { get; private set; }

        #region Методы клонирования
        public virtual object Clone() => MyClone();
        public virtual Pencil MyClone() => new Pencil(this.Length, this.Color);
        #endregion

        #region Переопределение вывода класса в строку
        public override string ToString() => $"Длина карандаша: {Length}.\r\nЦвет карандаша: {Color}.\r\n";
        #endregion

        #region Переопределение метода сравнения данного объекта
        public override bool Equals(object obj)
        {
            if (obj is Pencil other)
                return Length == other.Length && Color == other.Color;

            return false;
        }
        public override int GetHashCode() => HashCode.Combine(Length, Color);
        #endregion
    }
}
