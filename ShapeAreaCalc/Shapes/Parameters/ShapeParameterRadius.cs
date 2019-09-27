using System;

namespace ShapeAreaCalc.Shapes.Parameters
{
    /// <summary>
    /// Радиус фигуры
    /// </summary>
    internal class ShapeParameterRadius : AShapeParameter
    {
        /// <exception cref="ArgumentException"></exception>
        public ShapeParameterRadius(EShapeParameterType type, double value) : base(type, value) { }

        // радиус должен быть положительным ненулевым
        protected override bool IsValid => Value > 0;
    }
}