namespace Homework_4
{
    /// <summary>
    /// Механический карандаш.
    /// </summary>
    public class MechanicalPencils : Pencil, IMyCloneable<MechanicalPencils>, ICloneable
    {
        public MechanicalPencils(double penLength, string penColor, Lead lead) : base(penLength, penColor) => this.lead = lead;

        /// <summary>
        /// Грифель механического карандаша.
        /// </summary>
        public Lead lead { get; private set; }

        #region Методы клонирования
        public override MechanicalPencils MyClone() => new MechanicalPencils(this.length, this.color, lead.MyClone());
        public override object Clone() => MyClone();
        #endregion

        #region Переопределение вывода класса в строку
        public override string ToString() => $"Тип карандаша: механический карандаш.\r\n{base.ToString()}{lead}";
        #endregion

        #region Переопределение метода сравнения данного объекта
        public override bool Equals(object obj)
        {
            if (obj is MechanicalPencils other)
                return lead.Equals(other.lead) && base.Equals(other);

            return false;
        }
        public override int GetHashCode() => HashCode.Combine(base.GetHashCode(), lead.GetHashCode());
        #endregion
    }
}
