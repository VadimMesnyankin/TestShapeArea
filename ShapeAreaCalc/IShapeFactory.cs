using System;
using ShapeAreaCalc.Shapes;

namespace ShapeAreaCalc
{
    /// <summary>
    /// Фабрика фигур
    /// </summary>
    public interface IShapeFactory
    {
        /// <summary>
        /// Создание круга
        /// </summary>
        /// <param name="radius">радиус</param>
        /// <returns>круг</returns>
        /// <exception cref="ArgumentException"></exception>
        Circle CreateCircle(double radius);

        /// <summary>
        /// Создание треугольника
        /// </summary>
        /// <param name="sizeA">длина стороны A</param>
        /// <param name="sizeB">длина стороны B</param>
        /// <param name="sizeC">длина стороны C</param>
        /// <returns>треугольник</returns>
        /// <exception cref="ArgumentException"></exception>
        Triangle CreateTriangle(double sizeA, double sizeB, double sizeC);
    }
}