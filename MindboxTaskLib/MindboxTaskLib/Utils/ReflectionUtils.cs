using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;

namespace MindboxTaskLib.Utils
{
    internal static class ReflectionUtils
    {
        [NotNull]
        public static ICollection<Type> GetImplementationsOfInterface<T>([NotNull] T @interface)
        {
            if (@interface == null) throw new ArgumentNullException(nameof(@interface));

            var interfaceType = typeof(T);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => interfaceType.IsAssignableFrom(p) && !p.IsInterface && !p.IsAbstract)
                .ToList();

            return types;
        }
    }
}