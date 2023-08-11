using FigureCalculator.Figures;

namespace FigureCalculator
{
    /// <summary>
    /// Сервис взаимодействия с фигурами
    /// </summary>
    public class FigureService : IFigureService
    {
        public double CalculateArea(IFigure figure)
        {
            return figure.CalculateArea();
        }
    }
}
