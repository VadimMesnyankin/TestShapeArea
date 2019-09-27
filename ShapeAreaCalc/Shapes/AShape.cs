using ShapeAreaCalc.Shapes.Parameters;

namespace ShapeAreaCalc.Shapes
{
    /// <summary>
    /// Все фигуры наследуются от этого класса
    /// </summary>
    public abstract class AShape : Shape
    {
        protected override abstract EShapeParameterType[] requiredParameters { get; }

        public AShape() : base() { }

        /// <summary>
        /// Вычисление площади фигуры
        /// </summary>
        /// <returns>площадь</returns>
        /// <exception cref="ArgumentException"></exception>
        protected override abstract double CalculateArea();
    }
}