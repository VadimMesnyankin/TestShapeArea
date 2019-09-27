using ShapeAreaCalc.Shapes;

namespace ShapeAreaCalc
{
    /// <summary>
    /// Калькулятор площади фигуры
    /// </summary>
    public class ShapeAreaCalculator : IShapeAreaCalculator
    {
        /// <summary>
        /// Вычисление площади фигуры
        /// </summary>
        /// <param name="shape">фигура</param>
        /// <returns>площадь</returns>
        public double GetArea(IShape shape)
        {
            return shape.Area();
        }
    }
}