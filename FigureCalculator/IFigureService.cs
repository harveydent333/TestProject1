using FigureCalculator.Figures;

namespace FigureCalculator
{
    /// <summary>
    /// Интерфейс сервиса взаимодействия с фигурами
    /// </summary>
    public interface IFigureService
    {
        /// <summary>
        /// Вычислить площадь фигуры
        /// </summary>
        /// <param name="figure">Фигура</param>
        /// <returns>Площадь фигуры</returns>
        public double CalculateArea(IFigure figure);
    }
}
