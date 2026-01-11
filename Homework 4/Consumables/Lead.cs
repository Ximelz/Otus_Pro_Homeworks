namespace Homework_4
{
    /// <summary>
    /// Грифель.
    /// </summary>
    public class Lead : Consumables, IMyCloneable<Lead>, ICloneable
    {
        public Lead(string color, double pointSize) : base(color) => this.pointSize = pointSize;

        /// <summary>
        /// Толщина грифеля карандаша.
        /// </summary>
        public double pointSize { get; private set; }

        #region Методы клонирования
        public override Lead MyClone() => new Lead(this.color, this.pointSize);
        public override object Clone() => MyClone();
        #endregion

        #region Переопределение вывода класса в строку
        public override string ToString() => $"Тип расходника: грифель карандаша.\r\nТолщина линии: {pointSize} мм.\r\n{base.ToString()}";
        #endregion

        #region Переопределение метода сравнения данного объекта
        public override bool Equals(object obj)
        {
            if (obj is Lead other)
                return pointSize == other.pointSize && base.Equals(other);

            return false;
        }
        public override int GetHashCode() => HashCode.Combine(base.GetHashCode(), pointSize);
        #endregion
    }
}
