using MindboxTaskLib.Shapes;

namespace MindboxTaskLib.Calculators
{
    public interface IShapeCalculator
    {
        decimal CalculateSquare(IShape shape);
    }
}