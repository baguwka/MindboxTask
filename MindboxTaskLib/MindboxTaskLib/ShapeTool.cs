using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
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
            throw new NotImplementedException();
        }

        public decimal CalculateSquare(IShape shape)
        {
            var calculator = _CalculatorProvider.ProvideCalculatorFor(shape);
            if (calculator == null)
            {
                throw new CalculatorNotFoundException($"Calculator not found for shape {shape}");
            }

            return calculator.CalculateSquare(shape);
        }
    }
}