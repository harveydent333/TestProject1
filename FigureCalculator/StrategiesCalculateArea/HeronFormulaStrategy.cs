using FigureCalculator.Figures;

namespace FigureCalculator.StrategiesCalculateArea
{
    /// <summary>
    /// Стратегия вычисления площади треугольника по формуле Герона
    /// </summary>
    public class HeronFormulaStrategy : IStrategyCalculateTriangleArea
    {
        /// <summary>
        /// Вычислить площадь треугольника по формуле Герона
        /// </summary>
        /// <param name="triangle">Треугольник</param>
        /// <returns>Площадь фигуры</returns>
        public double CalculateArea(ITriangle triangle)
        {
            var perimeter = triangle.CalculatePerimeter();
            var semiperimeter = perimeter / 2;
            var area = Math.Sqrt(
                semiperimeter * (semiperimeter - triangle.A) * (semiperimeter - triangle.B) * (semiperimeter - triangle.C)
            );

            return Math.Round(area, 3);
        }
    }
}
