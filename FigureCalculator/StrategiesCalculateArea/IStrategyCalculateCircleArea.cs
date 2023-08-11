using FigureCalculator.Figures;

namespace FigureCalculator.StrategiesCalculateArea
{
    /// <summary>
    /// Интерфейс стратегии вычисления площади круга
    /// </summary>
    public interface IStrategyCalculateCircleArea
    {
        /// <summary>
        /// Вычислить площадь фигуры
        /// </summary>
        /// <param name="circle">Круг</param>
        /// <returns>Площадь круга</returns>
        public double CalculateArea(ICircle circle);
    }
}
