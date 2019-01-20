# MindboxTask
## Usage

```cs
IShapeTool shapeTool = new ShapeTool();

IShape triangle = GetTriangle(); //some method to instantiate a triangle
IShape circle = GetCircle(); //some method to instantiate a circle

Console.Writeline(shapeTool.CalculateArea(triangle));
Console.Writeline(shapeTool.CalculateArea(circle));
```

## Add a shape calculator

```cs
public class Square : IShape {}

[ForShape(Square)]
public class SquareShapeCalculator :ShapeCalculator
{
   //
}
```

## Sql scripts
https://github.com/baguwka/MindboxTask/blob/master/Sql/scripts.sql
