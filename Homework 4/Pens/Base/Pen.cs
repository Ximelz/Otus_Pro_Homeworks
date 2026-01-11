using System;
using System.Xml.Linq;

namespace Homework_4
{
    /// <summary>
    /// Ручка.
    /// </summary>
    public class Pen : IMyCloneable<Pen>, ICloneable
    {
        public Pen(double length, string color)
        {
            this.length = length;
            this.color = color;
        }

        /// <summary>
        /// Длина ручки.
        /// </summary>
        public double length { get; private set; }
        /// <summary>
        /// Цвет корпуса ручки.
        /// </summary>
        public string color { get; private set; }

        #region Методы клонирования
        public virtual object Clone() => MyClone();
        public virtual Pen MyClone() => new Pen(this.length, this.color);
        #endregion

        #region Переопределение вывода класса в строку
        public override string ToString() => $"Длина ручки: {length}.\r\nЦвет ручки: {color}.\r\n";
        #endregion

        #region Переопределение метода сравнения данного объекта
        public override bool Equals(object obj)
        {
            if (obj is Pen other)
                return length == other.length && color == other.color;

            return false;
        }
        public override int GetHashCode() => HashCode.Combine(length, color);
        #endregion
    }
}
