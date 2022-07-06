using FigureMeasuring;


double radius = 10;
FigureMeasuring.Types.Circle circle = new FigureMeasuring.Types.Circle(radius);
Console.WriteLine($"Circle's square: {circle.GetSquare()}");
//
// 
double[] sides = { 10, 6, 8 };
FigureMeasuring.Types.Triangle triangle = new FigureMeasuring.Types.Triangle(sides);
Console.WriteLine($"Triangle's square: {triangle.GetSquare()}");
Console.WriteLine($"Triangle's rectangularity: {triangle.IsRectangular()}");
//
//
double sideLength = 10;
int sidesCount = 15;
FigureMeasuring.Types.RegularPolygon poly = new FigureMeasuring.Types.RegularPolygon(sidesCount,sideLength);
Console.WriteLine($"Polygon's square: {poly.GetSquare()}");

