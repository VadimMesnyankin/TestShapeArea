namespace ShapeAreaCalc.Shapes
{
    /// <summary>
    /// "Строитель" фигур
    /// </summary>
    internal interface IShapeBuilder<TShape>
        where TShape : IShape, new()
    {
        /// <summary>
        /// Фигура
        /// </summary>
        TShape Build { get; }

        /// <summary>
        /// Задать радиус
        /// </summary>
        /// <param name="value">значение</param>
        /// <exception cref="ArgumentException"></exception>
        IShapeBuilder<TShape> AddRadius(double value);

        /// <summary>
        /// Задать сторону A
        /// </summary>
        /// <param name="value">значение</param>
        /// <exception cref="ArgumentException"></exception>
        IShapeBuilder<TShape> AddSizeA(double value);

        /// <summary>
        /// Задать сторону B
        /// </summary>
        /// <param name="value">значение</param>
        /// <exception cref="ArgumentException"></exception>
        IShapeBuilder<TShape> AddSizeB(double value);

        /// <summary>
        /// Задать сторону C
        /// </summary>
        /// <param name="value">значение</param>
        /// <exception cref="ArgumentException"></exception>
        IShapeBuilder<TShape> AddSizeC(double value);
    }
}