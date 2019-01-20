using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;
using MindboxTaskLib.Exceptions;
using MindboxTaskLib.Internal;
using MindboxTaskLib.Shapes;
using static System.Math;

namespace MindboxTaskLib.Calculators
{
    [ForShape(typeof(Triangle))]
    public class TriangleShapeCalculator : ShapeCalculator
    {
        public TriangleShapeCalculator()
        {
            
        }

        protected override double InternalCalculateAreaOf(IShape shape)
        {
            var triangle = (Triangle)shape;
            var a = triangle.A;
            var b = triangle.B;
            var c = triangle.C;

            if (IsTriangleIncorrect(a, b, c))
                throw new ShapeIsIncorrectExcception("Shape is incorrect");

            var p = (a + b + c) / 2;
            var area = Sqrt(p * (p - a) * (p - b) * (p - c));
            return area;
        }

        public bool IsTriangleIsRectangular(Triangle triangle)
        {
            var sides = GetSidesOfTrinagle(triangle)
                .ToList();

            var maxSide = sides.Max();
            var restSides = sides
                .Where(s => Abs(s - maxSide) > 0.001f)
                .ToList();

            return Abs(Pow(maxSide, 2) - (Pow(restSides[0], 2) + Pow(restSides[1], 2))) < 0.001f;
        }

        private IEnumerable<float> GetSidesOfTrinagle(Triangle triangle)
        {
            yield return triangle.A;
            yield return triangle.B;
            yield return triangle.C;
        }

        private bool IsTriangleIncorrect(float a, float b, float c)
        {
            var isCorrect = (a + b) > c &&
                            (b + c) > a &&
                            (c + a) > b;
            return !isCorrect;
        }
    }
}