# MindboxTask
## Usage

```cs
IShapeTool shapeTool = new ShapeTool();

IShape triangle = GetTriangle(); //some method to instantiate a triangle
IShape circle = GetCircle(); //some method to instantiate a circle

Console.Writeline(shapeTool.CalculateArea(triangle));
Console.Writeline(shapeTool.CalculateArea(circle));
```
