using System;

namespace ShapeAreaCalc.Shapes.Parameters
{
    /// <summary>
    /// Параметр создаваемой фигуры
    /// </summary>
    public abstract class AShapeParameter
    {
        /// <summary>
        /// Тип параметра
        /// </summary>
        public EShapeParameterType Type { get; }

        /// <summary>
        /// Значение параметра
        /// </summary>
        public double Value { get; }

        /// <summary>
        /// Является ли значение корректным (валидатор)
        /// </summary>
        protected abstract bool IsValid { get; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="type">тип параметра</param>
        /// <param name="value">значение параметра</param>
        /// <exception cref="ArgumentException"></exception>
        public AShapeParameter(EShapeParameterType type, double value)
        {
            Type = type;
            Value = value;
            if (!IsValid)
                throw new ArgumentException("Некорректное значение параметра");
        }
    }
}