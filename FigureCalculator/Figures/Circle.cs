using FigureCalculator.StrategiesCalculateArea;

namespace FigureCalculator.Figures
{
    public class Circle : ICircle
    {
        public double Radius { get; set; }

        private IStrategyCalculateCircleArea _strategyCalculateCircleArea;

        public Circle(double radius, IStrategyCalculateCircleArea strategy = default)
        {
            if (radius < 0)
                throw new FigureCalculatorException("Радиус круга не может быть отрицательный");

            Radius = radius;
            _strategyCalculateCircleArea = strategy;
        }

        /// <summary>
        /// Вычислить площадь круга
        /// </summary>
        /// <returns>Площадь круга</returns>
        /// <exception cref="FigureCalculatorException"></exception>
        public double CalculateArea()
        {
            if (_strategyCalculateCircleArea == null)
            {
                throw new FigureCalculatorException("Не определен способ вычисления площади");
            }

            return _strategyCalculateCircleArea.CalculateArea(this);
        }

        /// <summary>
        /// Вычислить периметр круга
        /// </summary>
        /// <returns>Периметр круга</returns>
        public double CalculatePerimeter()
        {
            var perimeter = 2 * Math.PI * Radius;
            return Math.Round(perimeter, 3);
        }
    }
}
