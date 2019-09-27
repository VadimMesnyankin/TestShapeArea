using System;
using ShapeAreaCalc.Shapes.Parameters;

namespace ShapeAreaCalc.Shapes
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : AShape
    {
        public Circle() : base() { }

        // Для вычисления площади круга необходимо знать его радиус
        protected override EShapeParameterType[] requiredParameters { get; } = new EShapeParameterType[] {
            EShapeParameterType.RADIUS
        };

        /// <summary>
        /// Вычисление площади фигуры
        /// </summary>
        /// <returns>площадь</returns>
        /// <exception cref="ArgumentException"></exception>
        protected override double CalculateArea()
        {
            // Площадь круга - произведение квадрата радиуса на число пи
            return Math.Pow(parameters[EShapeParameterType.RADIUS], 2) * Math.PI;
        }
    }
}