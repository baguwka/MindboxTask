using System;

namespace MindboxTaskLib.Shapes
{
    public class Circle : IShape
    {
        public Point Position { get; set; }
        public decimal Radius { get; set; }

        // pi * r ^ 2
        public decimal CalculateSquare()
        {
            throw new NotImplementedException();
        }
    }
}