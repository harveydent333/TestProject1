using FigureCalculator;
using FigureCalculator.Figures;
using FigureCalculator.StrategiesCalculateArea;

namespace Unit_Tests
{
    [TestClass]
    public class CirlceTests
    {
        /// <summary>
        /// Проверка, что круг не может быть с отрицательным радиусом
        /// </summary>
        [TestMethod]
        public void TryCreateCircleWithNegativeRadius()
        {
            Assert.ThrowsException<FigureCalculatorException>(() => new Circle(-10));
        }

        /// <summary>
        /// Проверка, что круг с позитивным радиусом корректно создан
        /// </summary>
        [TestMethod]
        public void CorrectCreateCircle()
        {
            Assert.IsNotNull(new Circle(10));
        }

        /// <summary>
        /// Проверка, что площадь круга не будет вычисляться без формулы
        /// </summary>
        [TestMethod]
        public void TryCalculateAreaWithoutFormula()
        {
            ICircle circle = new Circle(15);

            Assert.ThrowsException<FigureCalculatorException>(() => circle.CalculateArea());
        }

        /// <summary>
        /// Проверка, что корректно вычисляется периметр круга
        /// </summary>
        [TestMethod]
        public void CorrectCalculatePerimeterCircle()
        {
            ICircle circle = new Circle(15);
            var perimeter = circle.CalculatePerimeter();

            Assert.AreEqual(perimeter, 94.248);
        }

        /// <summary>
        /// Проверка, что корректно вычисляется площадь круга
        /// </summary>
        [TestMethod]
        public void CorrectCalculateAreaCircle()
        {
            IStrategyCalculateCircleArea strategy = new CircleAreaFormulaInTermsRadius();
            ICircle circle = new Circle(15, strategy);
            var area = circle.CalculateArea();

            Assert.AreEqual(area, 706.858);
        }
    }
}