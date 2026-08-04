using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        List<Shape> shapes = new List<Shape>();

        Square form1 = new Square("Blue", 5);
        shapes.Add(form1);

        Rectangle form2 = new Rectangle("Green", 4, 5);
        shapes.Add(form2);

        Circle form3 = new Circle("Yellow", 7);
        shapes.Add(form3);

        foreach (Shape s in shapes)
        {
            string tone = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The {tone} shape has an area of {area}.");
            Console.WriteLine("");
        }
    }
}