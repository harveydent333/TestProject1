using FigureCalculator.StrategiesCalculateArea;

namespace FigureCalculator.Figures
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public interface ITriangle : IFigure
    {
        /// <summary>
        /// Катет
        /// </summary>
        public double A { get; set; }

        /// <summary>
        /// Катет
        /// </summary>
        public double B { get; set; }

        /// <summary>
        /// Гипотенуза
        /// </summary>
        public double C { get; set; }

        /// <summary>
        /// Проверка на то, является ли треугольник прямоугольным
        /// </summary>
        /// <returns>true - если прямоугольный треугольник, false - нет</returns>
        public bool TriangleIsRight();

        /// <summary>
        /// Установить формулу вычисления площади треугольника
        /// </summary>
        public void SetCalculateFormula(IStrategyCalculateTriangleArea strategy);
    }
}
