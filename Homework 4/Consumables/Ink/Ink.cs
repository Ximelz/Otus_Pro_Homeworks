namespace Homework_4
{
    /// <summary>
    /// Чернила.
    /// </summary>
    public class Ink : Consumables, IMyCloneable<Ink>
    {
        public Ink(string Color, Container Container) : base(Color) => this.Container = Container;

        /// <summary>
        /// Емкость чернил.
        /// </summary>
        public Container Container { get; private set; }

        #region Методы клонирования
        public override Ink MyClone() => new Ink(this.Color, this.Container);
        #endregion

        #region Переопределение вывода класса в строку
        public override string ToString() => $"Тип расходника: чернила.\r\nЁмкость: {Container.GetString()}.\r\n{base.ToString()}";
        #endregion

        #region Переопределение метода сравнения данного объекта
        public override bool Equals(object obj)
        {
            if (obj is Ink other)
                return Container == other.Container && base.Equals(other);

            return false;
        }
        public override int GetHashCode() => HashCode.Combine(base.GetHashCode(), Container);
        #endregion
    }
}
