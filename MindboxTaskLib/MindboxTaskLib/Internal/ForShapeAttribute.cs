using System;

namespace MindboxTaskLib.Internal
{
    internal class ForShapeAttribute : Attribute
    {
        public Type ShapeTarget { get; }

        public ForShapeAttribute(Type shapeTarget)
        {
            ShapeTarget = shapeTarget;
        }
    }
}