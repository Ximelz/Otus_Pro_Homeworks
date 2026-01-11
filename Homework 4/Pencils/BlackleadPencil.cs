namespace Homework_4
{
    /// <summary>
    /// Графитовый карандаш.
    /// </summary>
    public class BlackleadPencil : Pencil, IMyCloneable<BlackleadPencil>, ICloneable
    {
        public BlackleadPencil(double penLength, string penColor) : base(penLength, penColor) { }

        #region Методы клонирования
        public override BlackleadPencil MyClone() => new BlackleadPencil(this.length, this.color);
        public override object Clone() => MyClone();
        #endregion

        #region Переопределение вывода класса в строку
        public override string ToString() => $"Тип карандаша: графитовый карандаш.\r\n{base.ToString()}";
        #endregion

        #region Переопределение метода сравнения данного объекта
        public override bool Equals(object obj)
        {
            if (obj is BlackleadPencil other)
                return base.Equals(other);

            return false;
        }
        public override int GetHashCode() => HashCode.Combine(base.GetHashCode());
        #endregion
    }
}
