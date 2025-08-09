using System;

abstract class Shape
{
    public abstract double GetArea();

}

class Circle : Shape
{
    double r;
    public Circle(double radius) { r = radius; }
    public override double GetArea() => 3.14 * r * r;
}

class Rectangle : Shape
{

    double w, h;
    public Rectangle(double width, double height) { w = width; h = height; }
    public override double GetArea() => w * h;
}

class App
{
    static void Main()
    {
        Shape c = new Circle(5);
        Shape r = new Rectangle(4, 6);

        Console.WriteLine("Circle Area: " + c.GetArea());
        Console.WriteLine("Rectangle Area: " + r.GetArea());
    }
}
