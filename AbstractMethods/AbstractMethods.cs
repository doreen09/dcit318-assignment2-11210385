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


class App
{
    static void Main()
    {
        Shape c = new Circle(5);
        Console.WriteLine("Circle Area: " + c.GetArea());

    }
}
