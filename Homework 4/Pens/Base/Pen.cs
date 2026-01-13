using System;
using System.Xml.Linq;

namespace Homework_4
{
    /// <summary>
    /// Ручка.
    /// </summary>
    public class Pen : IMyCloneable<Pen>, ICloneable
    {
        public Pen(double Length, string Color)
        {
            this.Length = Length;
            this.Color = Color;
        }

        /// <summary>
        /// Длина ручки.
        /// </summary>
        public double Length { get; private set; }
        /// <summary>
        /// Цвет корпуса ручки.
        /// </summary>
        public string Color { get; private set; }

        #region Методы клонирования
        public virtual object Clone() => MyClone();
        public virtual Pen MyClone() => new Pen(this.Length, this.Color);
        #endregion

        #region Переопределение вывода класса в строку
        public override string ToString() => $"Длина ручки: {Length}.\r\nЦвет ручки: {Color}.\r\n";
        #endregion

        #region Переопределение метода сравнения данного объекта
        public override bool Equals(object obj)
        {
            if (obj is Pen other)
                return Length == other.Length && Color == other.Color;

            return false;
        }
        public override int GetHashCode() => HashCode.Combine(Length, Color);
        #endregion
    }
}
