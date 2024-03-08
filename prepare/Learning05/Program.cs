using System;

Square sq = new("blue", 3);
Console.WriteLine(sq.GetColor());
Console.WriteLine(sq.GetArea());
sq.SetColor("green");
Console.WriteLine(sq.GetColor());

Rectangle r = new("red", 3, 4);
Console.WriteLine(r.GetColor());
Console.WriteLine(r.GetArea());
r.SetColor("pink");
Console.WriteLine(r.GetColor());

Circle c = new("purple", 1);
Console.WriteLine(c.GetColor());
Console.WriteLine(c.GetArea());
c.SetColor("orange");
Console.WriteLine(c.GetColor());

List<Shape> shapes = new();

Square s1 = new("Red", 3);
shapes.Add(s1);

Rectangle s2 = new("Blue", 4, 5);
shapes.Add(s2);

Circle s3 = new("Green", 6);
shapes.Add(s3);

foreach (Shape s in shapes)
{
    // Notice that all shapes have a GetColor method from the base class
    string color = s.GetColor();

    // Notice that all shapes have a GetArea method, but the behavior is
    // different for each type of shape
    double area = s.GetArea();

    Console.WriteLine($"The {color} shape has an area of {area}.");
}