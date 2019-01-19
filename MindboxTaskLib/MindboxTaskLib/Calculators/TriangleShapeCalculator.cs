using System;
using MindboxTaskLib.Internal;
using MindboxTaskLib.Shapes;

namespace MindboxTaskLib.Calculators
{
    [ForShape(typeof(Triangle))]
    public class TriangleShapeCalculator : IShapeCalculator
    {
        public TriangleShapeCalculator()
        {
            
        }

        public decimal CalculateSquare(IShape shape)
        {
            throw new NotImplementedException();
        }
    }
}