namespace MindboxTaskLib.Shapes
{
    public struct Point
    {
        public float X { get; set; }
        public float Y { get; set; }

        public static Point At(float x, float y)
        {
            return new Point
            {
                X = x,
                Y = y
            };
        }
    }
}