namespace FigureCalculator.Figures
{
    /// <summary>
    /// Фигура
    /// </summary>
    public interface IFigure
    {
        /// <summary>
        /// Вычислить площадь
        /// </summary>
        /// <returns>Площадь фигуры</returns>
        public double CalculateArea();

        /// <summary>
        /// Вычислить периметр
        /// </summary>
        /// <returns>Периметр фигуры</returns>
        public double CalculatePerimeter();
    }
}
