using System;
using MindboxTaskLib.Internal;
using MindboxTaskLib.Shapes;

namespace MindboxTaskLib.Calculators
{
    [ForShape(typeof(Circle))]
    public class CircleShapeCalculator : IShapeCalculator
    {
        public decimal CalculateSquare(IShape shape)
        {
            throw new NotImplementedException();
        }
    }
}