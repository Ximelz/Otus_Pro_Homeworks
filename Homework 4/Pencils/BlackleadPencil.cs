namespace Homework_4
{
    /// <summary>
    /// Графитовый карандаш.
    /// </summary>
    public class BlackPencilLeadPencil : Pencil, IMyCloneable<BlackPencilLeadPencil>, ICloneable
    {
        public BlackPencilLeadPencil(double PenLength, string PenColor) : base(PenLength, PenColor) { }

        #region Методы клонирования
        public override BlackPencilLeadPencil MyClone() => new BlackPencilLeadPencil(this.Length, this.Color);
        public override object Clone() => MyClone();
        #endregion

        #region Переопределение вывода класса в строку
        public override string ToString() => $"Тип карандаша: графитовый карандаш.\r\n{base.ToString()}";
        #endregion

        #region Переопределение метода сравнения данного объекта
        public override bool Equals(object obj)
        {
            if (obj is BlackPencilLeadPencil other)
                return base.Equals(other);

            return false;
        }
        public override int GetHashCode() => HashCode.Combine(base.GetHashCode());
        #endregion
    }
}
