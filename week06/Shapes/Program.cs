using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        List<Shape> _shapes = new List<Shape>();
        Square  square1 = new Square("red",2.2);
        Rectangle rectangle1 = new Rectangle("blue",3.4,2.5);
        Circle circle1 = new Circle("pink",4);

        Square square2 = new Square("purple",10);
        Rectangle rectangle2 = new Rectangle("white",14,8);
        Circle circle2 = new Circle("golden",7);

        _shapes.Add(square1);
        _shapes.Add(rectangle1);
        _shapes.Add(circle1);
        _shapes.Add(square2);
        _shapes.Add(rectangle2);
        _shapes.Add(circle2);
        foreach (Shape shape in _shapes)
        {
            Console.WriteLine(shape);
            
            Console.WriteLine($"{shape.GetArea()}");
           
            Console.WriteLine($"{shape.GetColor()}");
            Console.WriteLine();
        }



    }
}