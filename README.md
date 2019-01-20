# MindboxTask
## Usage

```cs
IShapeTool shapeTool // IoC or use defaullt constructor 

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

## Extend way to provide shape calculators
Instead of attribute provider you can setup any way to provide a calculator. When instantiating instance of ShapeTool do following:

```cs
IShapeCalculatorProvider provider = new NameConventionCalculatorProvider(); //NameConventionCalculatorProvider not exists at lib, it's an example that you can create
var shapeTool = new ShapeTool(provider);
```

## Sql scripts
https://github.com/baguwka/MindboxTask/blob/master/Sql/scripts.sql
