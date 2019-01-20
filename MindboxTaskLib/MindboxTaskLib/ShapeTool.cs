using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using MindboxTaskLib.Calculators;
using MindboxTaskLib.Exceptions;
using MindboxTaskLib.Internal;
using MindboxTaskLib.Shapes;

[assembly: InternalsVisibleTo("MindboxTask.Testing")]
namespace MindboxTaskLib
{
    public class ShapeTool : IShapeTool
    {
        private readonly IShapeCalculatorProvider _CalculatorProvider;

        public static IShapeTool NewShapeTool()
        {
            //TODO factory + ioc
            return new ShapeTool(new AttributeShapeCalculatorProvider());
        }

        internal ShapeTool([NotNull] IShapeCalculatorProvider calculatorProvider)
        {
            _CalculatorProvider = calculatorProvider ?? throw new ArgumentNullException(nameof(calculatorProvider));
        }

        public bool IsTriangleIsRectangular(Triangle triangle)
        {
            var triangleCalculator = new TriangleShapeCalculator();
            return triangleCalculator.IsTriangleIsRectangular(triangle);
        }

        public double CalculateArea(IShape shape)
        {
            var calculator = _CalculatorProvider.ProvideCalculatorFor(shape);
            return calculator.AreaOf(shape);
        }
    }
}