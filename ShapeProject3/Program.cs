namespace ShapeProject2;



public class Shape
{
    protected double length { get; set; }
    protected double width { get; set; }



    public virtual double GetArea()
    {
        return 0.0;
    }

    public virtual double GetPerimeter()
    {
        return 0.0;
    }

}

public class Rectangle : Shape
{
    public Rectangle(double l, double w)
    {

        length = l;
        width = w;
    }

    public override double GetArea()
    {
        return length * width;
    }

    public override double GetPerimeter()
    {
        return 2 * (length + width);
    }

}

public class Triangle : Shape
{
    public Triangle(double a, double b)
    {
        length = a;
        width = b;
    }

    public override double GetArea()
    {
        return 0.5 * length * width;
    }

    public override double GetPerimeter()
    {
        double hypotenuse = Math.Sqrt((length * length) + (width * width));
        return length + width + hypotenuse;

    }
}

public class Square : Shape
{
    public Square(double k)
    {
        length = k;
        width = k;
    }

    public override double GetArea()
    {
        return length * width;
    }

    public override double GetPerimeter()
    {
        return 4 * length;
    }
}

public class Circle : Shape
{
    public Circle(double r)
    {
        length = r;
        width = r;
    }

    public override double GetArea()
    {
        return Math.PI * length * length;
    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * length;

    }
}


public class Hexagon : Shape
{
    public Hexagon(double s)
    {
        length = s;
        width = s;
    }

    public override double GetArea()
    {
        return (3 * Math.Sqrt(3) * length * length) / 2;
    }

    public override double GetPerimeter()
    {
        return 6 * length;
    }

}

class Program
{
    static void Main(string[] args)
    {
        int choice, operation;
        double length, width;
        do
        {
            Console.WriteLine("1- Rectangle");
            Console.WriteLine("1- Triangle");
            Console.WriteLine("1- Square");
            Console.WriteLine("1- Circle");
            Console.WriteLine("1- Hexagon");

            Console.WriteLine("Enter Shape number: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("1- Calculate Area");
                    Console.WriteLine("2- Calculate Perimeter");
                    Console.WriteLine("Enter operation number: ");

                    operation = int.Parse(Console.ReadLine());

                    Console.Write("Enter length: ");
                    length = double.Parse(Console.ReadLine());

                    Console.Write("Enter width: ");
                    width = double.Parse(Console.ReadLine());

                    Rectangle rectangle = new Rectangle(length, width);

                    if (operation == 1)
                    {
                        Console.WriteLine("Area:{0}", rectangle.GetArea());

                    }
                    else if (operation == 2)
                    {
                        Console.WriteLine("Perimeter:{0}", rectangle.GetPerimeter);

                    }

                    else
                    {
                        Console.WriteLine("Invalid Operation Number");

                    }
                    break;
                case 2:
                    Console.WriteLine("1 - Calculate perimeter");
                    Console.WriteLine("2 - Calculate area");
                    Console.Write("Enter operation number: ");
                    operation = int.Parse(Console.ReadLine());

                    Console.Write("Enter side A length: ");
                    double sideA = double.Parse(Console.ReadLine());

                    Console.Write("Enter side B length: ");
                    double sideB = double.Parse(Console.ReadLine());



                    Triangle triangle = new Triangle(sideA, sideB);

                    if (operation == 1)
                    {
                        Console.WriteLine("Perimeter: {0}", triangle.GetPerimeter());
                    }
                    else if (operation == 2)
                    {
                        Console.WriteLine("Area: {0}", triangle.GetArea());
                    }
                    else
                    {
                        Console.WriteLine("Invalid operation number");
                    }

                    break;

                case 3:
                    Console.WriteLine("1 - Calculate perimeter");
                    Console.WriteLine("2 - Calculate area");
                    Console.Write("Enter operation number: ");
                    operation = int.Parse(Console.ReadLine());

                    Console.Write("Enter side length: ");
                    double side = double.Parse(Console.ReadLine());

                    Square square = new Square(side);

                    if (operation == 1)
                    {
                        Console.WriteLine("Perimeter: {0}", square.GetPerimeter());
                    }
                    else if (operation == 2)
                    {
                        Console.WriteLine("Area: {0}", square.GetArea());
                    }
                    else
                    {
                        Console.WriteLine("Invalid operation number");
                    }

                    break;

                case 4:
                    Console.WriteLine("1 - Calculate circumference");
                    Console.WriteLine("2 - Calculate area");
                    Console.Write("Enter operation number: ");
                    operation = int.Parse(Console.ReadLine());

                    Console.Write("Enter radius: ");
                    double radius = double.Parse(Console.ReadLine());

                    Circle circle = new Circle(radius);

                    if (operation == 1)
                    {
                        Console.WriteLine("Circumference: {0}", circle.GetPerimeter());
                    }
                    else if (operation == 2)
                    {
                        Console.WriteLine("Area: {0}", circle.GetArea());
                    }
                    else
                    {
                        Console.WriteLine("Invalid operation number");
                    }

                    break;

                case 5:
                    Console.WriteLine("1 - Calculate perimeter");
                    Console.WriteLine("2 - Calculate area");
                    Console.Write("Enter operation number: ");
                    operation = int.Parse(Console.ReadLine());

                    Console.Write("Enter side length: ");
                    double sideLength = double.Parse(Console.ReadLine());

                    Hexagon hexagon = new Hexagon(sideLength);

                    if (operation == 1)
                    {
                        Console.WriteLine("Perimeter: {0}", hexagon.GetPerimeter());
                    }
                    else if (operation == 2)
                    {
                        Console.WriteLine("Area: {0}", hexagon.GetArea());
                    }
                    else
                    {
                        Console.WriteLine("Invalid operation number");
                    }

                    break;

                case 0:
                    Console.WriteLine("Exiting program...");
                    return;


            }
        }

        while (choice != 0);
    }
}