using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;

namespace MindboxTaskLib.Utils
{
    internal static class ReflectionUtils
    {
        [NotNull]
        public static ICollection<Type> GetImplementationsOfInterface<T>()
        {
            var interfaceType = typeof(T);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p =>
                {
                    return interfaceType.IsAssignableFrom(p) && !p.IsInterface && !p.IsAbstract;
                })
                .ToList();

            return types;
        }
    }
}