using System;
using ShapeAreaCalc.Shapes.Parameters;

namespace ShapeAreaCalc.Shapes
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle : AShape
    {
        // Для вычисления площади треугольника необходимо знать длины его сторон
        protected override EShapeParameterType[] requiredParameters { get; } = new EShapeParameterType[] {
            EShapeParameterType.SIZE_A,
            EShapeParameterType.SIZE_B,
            EShapeParameterType.SIZE_C
        };

        public Triangle() : base() { }

        protected override bool ShapeCanExists()
        {
            // Треугольник с заданным размером сторон может существовать, если длина каждой
            // из его сторон больше суммы длин двух других
            return
                (parameters[EShapeParameterType.SIZE_A] < parameters[EShapeParameterType.SIZE_B] + parameters[EShapeParameterType.SIZE_C])
                &&
                (parameters[EShapeParameterType.SIZE_B] < parameters[EShapeParameterType.SIZE_A] + parameters[EShapeParameterType.SIZE_C])
                &&
                (parameters[EShapeParameterType.SIZE_C] < parameters[EShapeParameterType.SIZE_A] + parameters[EShapeParameterType.SIZE_B]);
        }

        /// <summary>
        /// Вычисление площади фигуры
        /// </summary>
        /// <returns>площадь</returns>
        /// <exception cref="ArgumentException"></exception>
        protected override double CalculateArea()
        {
            // Площадь треугольника вычисляется по формуле Герона
            double p = (parameters[EShapeParameterType.SIZE_A] + parameters[EShapeParameterType.SIZE_B] + parameters[EShapeParameterType.SIZE_C]) / 2;
            return Math.Sqrt(p * (p - parameters[EShapeParameterType.SIZE_A]) * (p - parameters[EShapeParameterType.SIZE_B]) * (p - parameters[EShapeParameterType.SIZE_C]));
        }

        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        /// <returns>bool</returns>
        /// <exception cref="ArgumentException"></exception>
        public bool IsRightTriangle()
        {
            if (!ShapeCanExists())
                throw new ArgumentException("Треугольник с заданными длинами сторон не может существовать");

            return
                (parameters[EShapeParameterType.SIZE_A] == Math.Sqrt(Math.Pow(parameters[EShapeParameterType.SIZE_B], 2) + Math.Pow(parameters[EShapeParameterType.SIZE_C], 2)))
                ||
                (parameters[EShapeParameterType.SIZE_B] == Math.Sqrt(Math.Pow(parameters[EShapeParameterType.SIZE_A], 2) + Math.Pow(parameters[EShapeParameterType.SIZE_C], 2)))
                ||
                (parameters[EShapeParameterType.SIZE_C] == Math.Sqrt(Math.Pow(parameters[EShapeParameterType.SIZE_A], 2) + Math.Pow(parameters[EShapeParameterType.SIZE_B], 2)));
        }
    }
}