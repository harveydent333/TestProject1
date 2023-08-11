using FigureCalculator.Figures;

namespace FigureCalculator.StrategiesCalculateArea
{
    /// <summary>
    /// Интерфейс стратегии вычисления площади треугольника
    /// </summary>
    public interface IStrategyCalculateTriangleArea
    {
        /// <summary>
        /// Вычислить площадь фигуры
        /// </summary>
        /// <param name="triangle">Треугольник</param>
        /// <returns>Площадь треугольника</returns>
        public double CalculateArea(ITriangle triangle);
    }
}
