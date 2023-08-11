using FigureCalculator;
using FigureCalculator.Figures;
using FigureCalculator.StrategiesCalculateArea;

namespace Unit_Tests
{
    [TestClass]
    public class TriangleTests
    {
        /// <summary>
        /// Проверка, что треугольник является прямоугольным
        /// </summary>
        [TestMethod]
        public void IsTriangleRight()
        {
            ITriangle triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.TriangleIsRight());
        }

        /// <summary>
        /// Проверка, что треугольник не является прямоугольным
        /// </summary>
        [TestMethod]
        public void IsNotTriangleRight()
        {
            ITriangle triangle = new Triangle(4, 4, 5);
            Assert.IsFalse(triangle.TriangleIsRight());
        }

        /// <summary>
        /// Проверка, что треугольника с такими сторонами не существует
        /// </summary>
        [TestMethod]
        public void TriangleIsNotExist()
        {
            Assert.ThrowsException<FigureCalculatorException>(() => new Triangle(100, 1, 1));
        }

        /// <summary>
        /// Проверка, что треугольника с такими сторонами существует
        /// </summary>
        [TestMethod]
        public void TriangleIsExist()
        {
            Assert.IsNotNull(new Triangle(100, 1, 100));
        }

        /// <summary>
        /// Проверка, что периметр треугольника корреткно вычисляется
        /// </summary>
        [TestMethod]
        public void CorrectCalculatePerimeter()
        {
            ITriangle triangle = new Triangle(100.54123, 1.55465546, 100.75568);
            var perimeter = triangle.CalculatePerimeter();

            Assert.AreEqual(perimeter, 202,852);
        }

        /// <summary>
        /// Проверка, что площадь треугольника не будет вычисляться без формулы
        /// </summary>
        [TestMethod]
        public void TryCalculateAreaWithoutFormula()
        {
            ITriangle triangle = new Triangle(100, 1, 100);

            Assert.ThrowsException<FigureCalculatorException>(() => triangle.CalculateArea());
        }

        /// <summary>
        /// Проверка, что площадь треугольника корректно вычисляется по формуле Герона
        /// </summary>
        [TestMethod]
        public void CalculateAreaWithHeronFormula()
        {
            IStrategyCalculateTriangleArea heronFormula = new HeronFormulaStrategy();
            ITriangle triangle = new Triangle(100, 1, 100, heronFormula);

            Assert.AreEqual(triangle.CalculateArea(), 49.999);
        }
    }
}