using FigureCalculator.Figures;

namespace FigureCalculator.StrategiesCalculateArea
{
    public class CircleAreaFormulaInTermsRadius : IStrategyCalculateCircleArea
    {
        public double CalculateArea(ICircle circle)
        {
            var area = Math.PI * Math.Pow(circle.Radius, 2);
            return Math.Round(area, 3);
        }
    }
}
