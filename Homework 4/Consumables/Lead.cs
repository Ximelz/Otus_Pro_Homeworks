namespace Homework_4
{
    /// <summary>
    /// Грифель.
    /// </summary>
    public class Lead : Consumables, IMyCloneable<Lead>
    {
        public Lead(string Color, double PointSize) : base(Color) => this.PointSize = PointSize;

        /// <summary>
        /// Толщина грифеля карандаша.
        /// </summary>
        public double PointSize { get; private set; }

        #region Методы клонирования
        public override Lead MyClone() => new Lead(this.Color, this.PointSize);
        #endregion

        #region Переопределение вывода класса в строку
        public override string ToString() => $"Тип расходника: грифель карандаша.\r\nТолщина линии: {PointSize} мм.\r\n{base.ToString()}";
        #endregion

        #region Переопределение метода сравнения данного объекта
        public override bool Equals(object obj)
        {
            if (obj is Lead other)
                return PointSize == other.PointSize && base.Equals(other);

            return false;
        }
        public override int GetHashCode() => HashCode.Combine(base.GetHashCode(), PointSize);
        #endregion
    }
}
