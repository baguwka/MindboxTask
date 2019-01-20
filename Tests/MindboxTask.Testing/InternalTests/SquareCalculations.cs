using System;
using System.Collections.Generic;
using MindboxTaskLib.Calculators;
using MindboxTaskLib.Internal;
using MindboxTaskLib.Shapes;
using NUnit.Framework;

namespace MindboxTask.Testing.InternalTests
{
    [TestFixture]
    public class SquareCalculations
    {

        public static IEnumerable<TestCaseData> CircleShapes
        {
            get
            {
                yield return new TestCaseData(new Circle
                    {
                        Radius = 10
                    },
                    314.15926535897932384626433832795d);

                yield return new TestCaseData(new Circle
                    {
                        Radius = 5755
                    },
                    104049627.2267102918027137104203d);
            }
        }

        public static IEnumerable<TestCaseData> TriangleShapes
        {
            get
            {
                yield return new TestCaseData(new Triangle
                    {
                        A = 10,
                        B = 10,
                        C = 10
                    },
                    43.301270189221931d);

                yield return new TestCaseData(new Triangle
                    {
                        A = 3,
                        B = 4,
                        C = 5
                    },
                    6f);

                yield return new TestCaseData(new Triangle
                    {
                        A = 15,
                        B = 16,
                        C = 25
                    },
                    114.47270417003348d);
            }
        }

        public static IEnumerable<TestCaseData> RectangularTrianglesCases
        {
            get
            {
                yield return new TestCaseData(new Triangle()
                {
                    A = 3,
                    B = 4,
                    C = 5
                }, true);
                yield return new TestCaseData(new Triangle()
                {
                    A = 6,
                    B = 8,
                    C = 10
                }, true);
                yield return new TestCaseData(new Triangle()
                {
                    A = 9,
                    B = 12,
                    C = 15
                }, true);


                yield return new TestCaseData(new Triangle()
                {
                    A = 2,
                    B = 5,
                    C = 6
                }, false);
                yield return new TestCaseData(new Triangle()
                {
                    A = 7,
                    B = 8,
                    C = 10
                }, false);
                yield return new TestCaseData(new Triangle()
                {
                    A = 10,
                    B = 12,
                    C = 15
                }, false);
            }
        }

        [TestCaseSource(nameof(CircleShapes))]
        [TestCaseSource(nameof(TriangleShapes))]
        public void CalculateSquareOfShape(IShape shape, double expectedSquare)
        {
            var actualSquare = InternalCalculateSquareOf(shape);
            Assert.That(actualSquare, Is.EqualTo(expectedSquare));
        }

        [TestCaseSource(nameof(RectangularTrianglesCases))]
        public void IsTriangleIsRectangular(Triangle shape, bool expected)
        {
            var triangleCalculator = new TriangleShapeCalculator();
            var actual = triangleCalculator.IsTriangleIsRectangular(shape);
            Assert.That(actual, Is.EqualTo(expected));
        }

        private double InternalCalculateSquareOf(IShape shape)
        {
            var provider = new AttributeShapeCalculatorProvider();
            var calculator = provider.ProvideCalculatorFor(shape);

            return calculator.AreaOf(shape);
        }
    }
}