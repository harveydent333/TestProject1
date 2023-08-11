using FigureCalculator.StrategiesCalculateArea;
using FigureCalculator.Figures;
using FigureCalculator;

namespace TestProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            try
            {
                var triangle = new Triangle(3, 5, 6, new HeronFormulaStrategy());
                var triangle2 = new Triangle(3, 4, 5, new HeronFormulaStrategy());
                Console.WriteLine(triangle.TriangleIsRight());
                Console.WriteLine(triangle2.TriangleIsRight());

                FigureService figureService = new FigureService();

                Console.WriteLine(figureService.CalculateArea(triangle));
            }
            catch (FigureCalculatorException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                //логгирование
                Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
            }

        }
    }
}