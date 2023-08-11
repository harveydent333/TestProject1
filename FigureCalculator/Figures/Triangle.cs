using FigureCalculator.StrategiesCalculateArea;

namespace FigureCalculator.Figures
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle : ITriangle
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
        public bool TriangleIsRight()
        {
            return Math.Pow(A, 2) + Math.Pow(B, 2) == Math.Pow(C, 2);
        }

        /// <summary>
        /// Установить формулу вычисления площади треугольника
        /// </summary>
        public void SetCalculateFormula(IStrategyCalculateTriangleArea strategy)
        {
            _strategyCalculateTriangleArea = strategy ??
                throw new FigureCalculatorException("Формула вычисления площади треугольника отсутствует");
        }

        private IStrategyCalculateTriangleArea _strategyCalculateTriangleArea;

        public Triangle(double a, double b, double c, IStrategyCalculateTriangleArea strategy = default)
        {
            if (!IsTriangleExist(a, b, c))
            {
                throw new FigureCalculatorException("Такого треугольника не существует");
            }

            A = a;
            B = b;
            C = c;
            _strategyCalculateTriangleArea = strategy;
        }

        /// <summary>
        /// Проверка, существует ли треугольник
        /// </summary>
        /// <returns>true - существует, false - нет</returns>
        private bool IsTriangleExist(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        /// <summary>
        /// Вычислить периметр
        /// </summary>
        /// <returns>Периметр фигуры</returns>
        public double CalculatePerimeter()
        {
            var perimeter = A + B + C;
            return Math.Round(perimeter, 3);
        }

        /// <summary>
        /// Вычислить площадь треугольника
        /// </summary>
        /// <returns>Площадь треугольника</returns>
        /// <exception cref="FigureCalculatorException"></exception>
        public double CalculateArea()
        {
            if (_strategyCalculateTriangleArea == null)
            {
                throw new FigureCalculatorException("Не определен способ вычисления площади");
            }

            return _strategyCalculateTriangleArea.CalculateArea(this);
        }
    }
}
