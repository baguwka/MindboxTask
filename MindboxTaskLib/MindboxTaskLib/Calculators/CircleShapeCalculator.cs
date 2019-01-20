using System;
using System.Reflection;
using MindboxTaskLib.Internal;
using MindboxTaskLib.Shapes;

namespace MindboxTaskLib.Calculators
{
    [ForShape(typeof(Circle))]
    public class CircleShapeCalculator : ShapeCalculator
    {
        public CircleShapeCalculator()
        {
            
        }

        protected override double InternalCalculateAreaOf(IShape shape)
        {
            var circle = (Circle)shape;
            return Math.PI * Math.Pow(circle.Radius, 2);
        }
    }
}