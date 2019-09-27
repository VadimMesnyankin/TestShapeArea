namespace ShapeAreaCalc.Shapes.Parameters
{
    /// <summary>
    /// Длина стороны фигуры
    /// </summary>
    internal class ShapeParameterSizeLength : AShapeParameter
    {
        /// <exception cref="ArgumentException"></exception>
        public ShapeParameterSizeLength(EShapeParameterType type, double value) : base(type, value) { }

        // Длина стороны фигура должны быть положительной ненулевой
        protected override bool IsValid => Value > 0;
    }
}