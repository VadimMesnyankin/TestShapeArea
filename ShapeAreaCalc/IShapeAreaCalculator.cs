using ShapeAreaCalc.Shapes;

namespace ShapeAreaCalc
{
    /// <summary>
    /// Калькулятор площади фигуры
    /// </summary>
    public interface IShapeAreaCalculator
    {
        /// <summary>
        /// Вычисление площади фигуры
        /// </summary>
        /// <param name="shape">фигура</param>
        /// <returns>площадь</returns>
        double GetArea(IShape shape);
    }
}