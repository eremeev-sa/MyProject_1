Figure circle1 = new Circle(5);
Console.WriteLine(circle1.Calculator());

Figure triangle1 = new Triangle(3, 4, 5);

Console.WriteLine(triangle1.Calculator());
Console.WriteLine((triangle1 as Triangle).rightTriangle());