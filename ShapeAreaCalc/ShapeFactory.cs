using ShapeAreaCalc.Shapes;

namespace ShapeAreaCalc
{
    /// <summary>
    /// Фабрика фигур
    /// </summary>
    public class ShapeFactory : IShapeFactory
    {
        /// <summary>
        /// Создание круга
        /// </summary>
        /// <param name="radius">радиус</param>
        /// <returns>круг</returns>
        /// <exception cref="ArgumentException"></exception>
        public Circle CreateCircle(double radius)
        {
            return new ShapeBuilder<Circle>()
                .AddRadius(radius)
                .Build;
        }

        /// <summary>
        /// Создание треугольника
        /// </summary>
        /// <param name="sizeA">длина стороны A</param>
        /// <param name="sizeB">длина стороны B</param>
        /// <param name="sizeC">длина стороны C</param>
        /// <returns>треугольник</returns>
        /// <exception cref="ArgumentException"></exception>
        public Triangle CreateTriangle(double sizeA, double sizeB, double sizeC)
        {
            return new ShapeBuilder<Triangle>()
                .AddSizeA(sizeA)
                .AddSizeB(sizeB)
                .AddSizeC(sizeC)
                .Build;
        }
    }
}