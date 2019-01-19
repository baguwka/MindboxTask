using MindboxTaskLib.Exceptions;
using MindboxTaskLib.Shapes;

namespace MindboxTaskLib
{
    public interface IShapeTool
    {
        bool IsTriangleIsRectangular(Triangle triangle);

        /// <exception cref="CalculatorNotFoundException"></exception>
        decimal CalculateSquare(IShape shape);
    }
}