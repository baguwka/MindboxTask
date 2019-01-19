using System;
using System.Linq;
using System.Reflection;
using MindboxTaskLib.Calculators;
using MindboxTaskLib.Shapes;

namespace MindboxTaskLib.Internal
{
    internal class AttributeShapeCalculatorProvider : IShapeCalculatorProvider
    {
        private CalculatorsContainer CalculatorsContainer { get; }

        public AttributeShapeCalculatorProvider()
        {
            CalculatorsContainer = new CalculatorsContainer();
        }

        public IShapeCalculator ProvideCalculatorFor(IShape shape)
        {
            if (shape == null) throw new ArgumentNullException(nameof(shape));

            var shapeType = shape.GetType();
            var desiredCalculator = CalculatorsContainer.Items
                .FirstOrDefault(c =>
                {
                    var attr = c.GetType().GetCustomAttribute<ForShapeAttribute>(false);
                    return attr.ShapeTarget?.Equals(shapeType) ?? false;
                });

            return desiredCalculator;
        }
    }
}