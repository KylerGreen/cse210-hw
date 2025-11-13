using System;

class Program
{
    static void Main(string[] args)
    {
        Shape circleTest = new Circle("blue", 5);
        Console.WriteLine($"Circle Color: {circleTest.GetColor()}");
        Console.WriteLine($"Circle Area: {circleTest.GetArea()}");
        Console.WriteLine();

        Shape rectangleTest = new Rectangle("green", 5, 10);
        Console.WriteLine($"Rectangle Color: {rectangleTest.GetColor()}");
        Console.WriteLine($"Rectangle Area: {rectangleTest.GetArea()}");
        Console.WriteLine();

        Shape squareTest = new Square("red", 5);
        Console.WriteLine($"Square Color: {squareTest.GetColor()}");
        Console.WriteLine($"Square Area: {squareTest.GetArea()}");
        Console.WriteLine();

    }
}