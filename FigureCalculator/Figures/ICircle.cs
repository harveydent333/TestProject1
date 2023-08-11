namespace FigureCalculator.Figures
{
    /// <summary>
    /// Круг
    /// </summary>
    public interface ICircle : IFigure
    {
        /// <summary>
        /// Радиус
        /// </summary>
        public double Radius { get; set; }
    }
}