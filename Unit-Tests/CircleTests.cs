using FigureCalculator;
using FigureCalculator.Figures;
using FigureCalculator.StrategiesCalculateArea;

namespace Unit_Tests
{
    [TestClass]
    public class CirlceTests
    {
        /// <summary>
        /// ��������, ��� ���� �� ����� ���� � ������������� ��������
        /// </summary>
        [TestMethod]
        public void TryCreateCircleWithNegativeRadius()
        {
            Assert.ThrowsException<FigureCalculatorException>(() => new Circle(-10));
        }

        /// <summary>
        /// ��������, ��� ���� � ���������� �������� ��������� ������
        /// </summary>
        [TestMethod]
        public void CorrectCreateCircle()
        {
            Assert.IsNotNull(new Circle(10));
        }

        /// <summary>
        /// ��������, ��� ������� ����� �� ����� ����������� ��� �������
        /// </summary>
        [TestMethod]
        public void TryCalculateAreaWithoutFormula()
        {
            ICircle circle = new Circle(15);

            Assert.ThrowsException<FigureCalculatorException>(() => circle.CalculateArea());
        }

        /// <summary>
        /// ��������, ��� ��������� ����������� �������� �����
        /// </summary>
        [TestMethod]
        public void CorrectCalculatePerimeterCircle()
        {
            ICircle circle = new Circle(15);
            var perimeter = circle.CalculatePerimeter();

            Assert.AreEqual(perimeter, 94.248);
        }

        /// <summary>
        /// ��������, ��� ��������� ����������� ������� �����
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