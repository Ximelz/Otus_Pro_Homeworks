namespace Homework_4
{
    public static class EnumToStringExtensions
    {
        /// <summary>
        /// Метод расширения для отображения типа толщины пера.
        /// </summary>
        /// <param name="size">Обозначение толщины пера.</param>
        /// <returns>Толщина пера на русском.</returns>
        public static string GetString(this FountainPenSize size) => size switch {
                                                                          FountainPenSize.EF => "Экстра-тонкое",
                                                                          FountainPenSize.F => "Тонкое",
                                                                          FountainPenSize.MF => "Средне-тонкое",
                                                                          FountainPenSize.M => "Среднее",
                                                                          FountainPenSize.B => "Широкое",
                                                                          FountainPenSize.EB => "Экстра-широкое" };

        /// <summary>
        /// Метод расширения для отображения емкости чернил.
        /// </summary>
        /// <param name="container">Тип емкости.</param>
        /// <returns>Тип емкости на русском.</returns>
        public static string GetString(this InkContainer container) => container switch {
                                                                                 InkContainer.Bottle => "Баночка",
                                                                                 InkContainer.Cartridge => "Картридж" };
    }
}
