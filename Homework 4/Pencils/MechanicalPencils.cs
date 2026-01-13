namespace Homework_4
{
    /// <summary>
    /// Механический карандаш.
    /// </summary>
    public class MechanicalPencils : Pencil, IMyCloneable<MechanicalPencils>, ICloneable
    {
        public MechanicalPencils(double PenLength, string PenColor, Lead PencilLead) : base(PenLength, PenColor) => this.PencilLead = PencilLead;

        /// <summary>
        /// Грифель механического карандаша.
        /// </summary>
        public Lead PencilLead { get; private set; }

        #region Методы клонирования
        public override MechanicalPencils MyClone() => new MechanicalPencils(this.Length, this.Color, PencilLead.MyClone());
        public override object Clone() => MyClone();
        #endregion

        #region Переопределение вывода класса в строку
        public override string ToString() => $"Тип карандаша: механический карандаш.\r\n{base.ToString()}{PencilLead}";
        #endregion

        #region Переопределение метода сравнения данного объекта
        public override bool Equals(object obj)
        {
            if (obj is MechanicalPencils other)
                return PencilLead.Equals(other.PencilLead) && base.Equals(other);

            return false;
        }
        public override int GetHashCode() => HashCode.Combine(base.GetHashCode(), PencilLead.GetHashCode());
        #endregion
    }
}
