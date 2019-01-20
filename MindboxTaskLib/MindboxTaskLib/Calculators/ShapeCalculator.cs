using System.Reflection;
using MindboxTaskLib.Exceptions;
using MindboxTaskLib.Internal;
using MindboxTaskLib.Shapes;

namespace MindboxTaskLib.Calculators
{
    public abstract class ShapeCalculator
    {
        /// <exception cref="InvalidShapeException"></exception>>
        /// <exception cref="ShapeIsIncorrectExcception"></exception>>
        public double AreaOf(IShape shape)
        {
            if (this.GetType().GetCustomAttribute<ForShapeAttribute>()?.ShapeTarget != shape.GetType())
                throw new InvalidShapeException($"You provide invalid shape for calculator of type {this.GetType()}");

            return InternalCalculateAreaOf(shape);
        }

        protected abstract double InternalCalculateAreaOf(IShape shape);
    }
}