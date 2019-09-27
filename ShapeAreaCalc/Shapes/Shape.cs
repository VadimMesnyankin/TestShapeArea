using System;
using System.Collections.Generic;
using System.Linq;
using ShapeAreaCalc.Shapes.Parameters;

namespace ShapeAreaCalc.Shapes
{
    /// <summary>
    /// Фигура
    /// </summary>
    public class Shape : IShape
    {
        /// <summary>
        /// Параметры фигуры EShapeParameterType=>Value
        /// </summary>
        protected Dictionary<EShapeParameterType, double> parameters = new Dictionary<EShapeParameterType, double>();

        /// <summary>
        /// Список необходимых параметров для вычисления площади фигуры
        /// </summary>
        protected virtual EShapeParameterType[] requiredParameters { get; } = new EShapeParameterType[] { };

        public Shape() { }

        /// <summary>
        /// Добавление параметра
        /// </summary>
        /// <param name="parameter">тип параметра</param>
        /// <exception cref="ArgumentException"></exception>
        public void AddParameter(AShapeParameter parameter)
        {
            // Добавить или обновить значение
            if (!parameters.ContainsKey(parameter.Type))
                parameters.Add(parameter.Type, parameter.Value);
            else
                parameters[parameter.Type] = parameter.Value;
        }

        /// <summary>
        /// Вычисление площади фигуры
        /// </summary>
        /// <returns>площадь</returns>
        /// <exception cref="ArgumentException"></exception>
        public double Area()
        {
            // Исключение, если у фигуры недостаточно параметров для вычисления площади
            if (requiredParameters.Except(parameters.Keys.AsEnumerable()).Any())
                throw new ArgumentException("Параметров фигуры недостаточно для вычисления площади");

            // Исключение, если фигура с заданными сторонами не может существовать
            if (!ShapeCanExists())
                throw new ArgumentException("Фигура с заданными параметрами не может существовать");

            return CalculateArea();
        }

        /// <summary>
        /// Может ли существовать фигура с заданными параметрами
        /// </summary>
        protected virtual bool ShapeCanExists()
        {
            return true;
        }

        /// <summary>
        /// Вычисление площади фигуры
        /// </summary>
        /// <returns>площадь</returns>
        /// <exception cref="ArgumentException"></exception>
        protected virtual double CalculateArea()
        {
            throw new NotImplementedException("Площадь фигуры не может быть вычислена");
        }
    }
}