using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace MindboxTaskLib.Shapes
{
    public class NGon : IShape
    {
        public IReadOnlyCollection<Point> Points { get; set; }

        public NGon(IEnumerable<Point> points)
        {
            if (points == null) throw new ArgumentNullException(nameof(points));

            Points = new ReadOnlyCollection<Point>(points.ToList());
        }
    }
}