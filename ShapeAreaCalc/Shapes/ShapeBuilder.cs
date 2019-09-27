using ShapeAreaCalc.Shapes.Parameters;

namespace ShapeAreaCalc.Shapes
{
    /// <summary>
    /// "Строитель" фигур
    /// </summary>
    internal class ShapeBuilder<TShape> : IShapeBuilder<TShape>
        where TShape : IShape, new()
    {
        public TShape Build { get; } = new TShape();

        /// <exception cref="ArgumentException"></exception>
        public IShapeBuilder<TShape> AddRadius(double value)
        {
            Build.AddParameter(new ShapeParameterRadius(EShapeParameterType.RADIUS, value));
            return this;
        }

        /// <exception cref="ArgumentException"></exception>
        public IShapeBuilder<TShape> AddSizeA(double value)
        {
            Build.AddParameter(new ShapeParameterSizeLength(EShapeParameterType.SIZE_A, value));
            return this;
        }

        /// <exception cref="ArgumentException"></exception>
        public IShapeBuilder<TShape> AddSizeB(double value)
        {
            Build.AddParameter(new ShapeParameterSizeLength(EShapeParameterType.SIZE_B, value));
            return this;
        }

        /// <exception cref="ArgumentException"></exception>
        public IShapeBuilder<TShape> AddSizeC(double value)
        {
            Build.AddParameter(new ShapeParameterSizeLength(EShapeParameterType.SIZE_C, value));
            return this;
        }
    }
}