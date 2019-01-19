using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using MindboxTaskLib.Calculators;
using MindboxTaskLib.Internal;
using MindboxTaskLib.Shapes;
using MindboxTaskLib.Utils;
using NUnit.Framework;

namespace MindboxTask.Testing.InternalTests
{
    [TestFixture]
    public class EnsureCalculatorsHaveAttributesTesting
    {
        public static IEnumerable<TestCaseData> CalculatorsCases
        {
            get
            {
                var types = ReflectionUtils.GetImplementationsOfInterface<IShapeCalculator>();
                return types
                    .Select(t => Activator.CreateInstance(t) as IShapeCalculator)
                    .Where(c => c != null)
                    .Select(c => new TestCaseData(c));
            }
        }

        [TestCaseSource(nameof(CalculatorsCases))]
        public void EnsureCalculatorHaveForShapeAttribute(IShapeCalculator calculator)
        {
            var attr = calculator.GetType().GetCustomAttribute<ForShapeAttribute>(false);
            Assert.That(attr, Is.Not.Null);
        }

        [TestCaseSource(nameof(CalculatorsCases))]
        public void EnsureForShapeAttributeHaveShape(IShapeCalculator calculator)
        {
            var attr = calculator.GetType().GetCustomAttribute<ForShapeAttribute>(false);
            Assert.That(attr.ShapeTarget, Is.Not.Null);
            var isAssig2 = (typeof(IShape)).IsAssignableFrom(attr.ShapeTarget);
            Assert.That(isAssig2, Is.True);
        }
    }
}
