namespace Homework_4
{
    /// <summary>
    /// Чернила.
    /// </summary>
    public class Ink : Consumables, IMyCloneable<Ink>, ICloneable
    {
        public Ink(string color, InkContainer inkContainer) : base(color) => this.inkContainer = inkContainer;

        /// <summary>
        /// Емкость чернил.
        /// </summary>
        public InkContainer inkContainer { get; private set; }

        #region Методы клонирования
        public override Ink MyClone() => new Ink(this.color, this.inkContainer);
        public override object Clone() => MyClone();
        #endregion

        #region Переопределение вывода класса в строку
        public override string ToString() => $"Тип расходника: чернила.\r\nЁмкость: {inkContainer.GetString()}.\r\n{base.ToString()}";
        #endregion

        #region Переопределение метода сравнения данного объекта
        public override bool Equals(object obj)
        {
            if (obj is Ink other)
                return inkContainer == other.inkContainer && base.Equals(other);

            return false;
        }
        public override int GetHashCode() => HashCode.Combine(base.GetHashCode(), inkContainer);
        #endregion
    }
}
