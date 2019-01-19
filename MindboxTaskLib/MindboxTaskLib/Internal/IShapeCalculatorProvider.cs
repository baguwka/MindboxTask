using JetBrains.Annotations;
using MindboxTaskLib.Calculators;
using MindboxTaskLib.Shapes;

namespace MindboxTaskLib.Internal
{
    internal interface IShapeCalculatorProvider
    {
        [CanBeNull]
        IShapeCalculator ProvideCalculatorFor([NotNull] IShape shape);
    }
}