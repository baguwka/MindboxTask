using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using MindboxTaskLib.Calculators;
using MindboxTaskLib.Utils;

namespace MindboxTaskLib.Internal
{
    internal class CalculatorsContainer
    {
        private ICollection<ShapeCalculator> _Items;

        [NotNull]
        [ItemNotNull]
        public ICollection<ShapeCalculator> Items {
            get 
            {
                if (_Items != null)
                    return _Items;

                var calculatorTypes = ReflectionUtils.GetImplementationsOfInterface<ShapeCalculator>();
                _Items = calculatorTypes
                    .Select(t => Activator.CreateInstance(t) as ShapeCalculator)
                    .Where(c => c != null)
                    .ToList();

                return _Items;
            }
        }
    }
}