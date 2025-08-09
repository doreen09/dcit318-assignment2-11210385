using System;

interface IMovable
{
    void Move();
}

class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}
class App
{
    static void Main()
    {
        Car car = new Car();
        car.Move();

    }
}