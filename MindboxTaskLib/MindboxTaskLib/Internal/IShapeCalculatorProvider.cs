using JetBrains.Annotations;
using MindboxTaskLib.Calculators;
using MindboxTaskLib.Shapes;

namespace MindboxTaskLib.Internal
{
    public interface IShapeCalculatorProvider
    {
        /// <exception cref="CalculatorNotFoundException"></exception>
        [NotNull]
        ShapeCalculator ProvideCalculatorFor([NotNull] IShape shape);
    }
}