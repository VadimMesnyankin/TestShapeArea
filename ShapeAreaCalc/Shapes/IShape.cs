using System;
using ShapeAreaCalc.Shapes.Parameters;

namespace ShapeAreaCalc.Shapes
{
    /// <summary>
    /// Фигура
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// Добавление параметра
        /// </summary>
        /// <param name="parameter">параметр</param>
        /// <exception cref="ArgumentException"></exception>
        void AddParameter(AShapeParameter parameter);

        /// <summary>
        /// Вычисление площади фигуры
        /// </summary>
        /// <returns>площадь</returns>
        /// <exception cref="ArgumentException"></exception>
        double Area();
    }
}