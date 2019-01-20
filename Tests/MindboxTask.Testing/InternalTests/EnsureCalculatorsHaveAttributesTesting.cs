using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using MindboxTaskLib.Calculators;
using MindboxTaskLib.Internal;
using MindboxTaskLib.Shapes;
using MindboxTaskLib.Utils;
using NUnit.Framework;

namespace MindboxTask.Testing.InternalTests
{
    [TestFixture]
    public class EnsureHaveKnownShapeCalculators
    {
        [Test]
        public void HasProviderForCircle()
        {
            var provider = new AttributeShapeCalculatorProvider();
            var calculator = provider.ProvideCalculatorFor(new Circle());
            Assert.That(calculator, Is.Not.Null);
        }

        [Test]
        public void HasProviderForTriangle()
        {
            var provider = new AttributeShapeCalculatorProvider();
            var calculator = provider.ProvideCalculatorFor(new Triangle());
            Assert.That(calculator, Is.Not.Null);
        }

        [Test]
        public void HasProviderForSquare()
        {
            var provider = new AttributeShapeCalculatorProvider();
            var calculator = provider.ProvideCalculatorFor(new Square());
            Assert.That(calculator, Is.Not.Null);
        }
    }

    [TestFixture]
    public class EnsureCalculatorsHaveAttributesTesting
    {
        public static IEnumerable<TestCaseData> CalculatorsCases
        {
            get
            {
                var types = ReflectionUtils.GetImplementationsOfInterface<ShapeCalculator>();
                return types
                    .Select(t => Activator.CreateInstance(t) as ShapeCalculator)
                    .Where(c => c != null)
                    .Select(c => new TestCaseData(c));
            }
        }

        [TestCaseSource(nameof(CalculatorsCases))]
        public void EnsureCalculatorHaveForShapeAttribute(ShapeCalculator calculator)
        {
            var attr = calculator.GetType().GetCustomAttribute<ForShapeAttribute>(false);
            Assert.That(attr, Is.Not.Null);
        }

        [TestCaseSource(nameof(CalculatorsCases))]
        public void EnsureForShapeAttributeHaveShape(ShapeCalculator calculator)
        {
            var attr = calculator.GetType().GetCustomAttribute<ForShapeAttribute>(false);
            Assert.That(attr.ShapeTarget, Is.Not.Null);
            var isAssignableFromIShape = (typeof(IShape)).IsAssignableFrom(attr.ShapeTarget);
            Assert.That(isAssignableFromIShape, Is.True);
        }
    }
}
