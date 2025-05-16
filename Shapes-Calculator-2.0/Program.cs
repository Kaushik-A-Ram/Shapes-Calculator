using Shapes_Calculator_2._0;

namespace Shapes_Calculator_2._0
{
    interface IShape
    {
        float Area();
        float Perimeter();
    }

    class Rectangle : IShape
    {
        public float Height { get; }
        public float Width { get; }

        public Rectangle(float height, float width)
        {
            Height = height;
            Width = width;
        }

        public float Area() => Height * Width;

        public float Perimeter() => 2 * (Height + Width);
    }

    class Square : IShape
    {
        public float Side { get; }

        public Square(float side)
        {
            Side = side;
        }

        public float Area() => Side * Side;

        public float Perimeter() => 4 * Side;
    }

    class Circle : IShape
    {
        public float Radius { get; }

        public Circle(float radius)
        {
            Radius = radius;
        }

        public float Area() => (float)Math.PI * Radius * Radius;

        public float Perimeter() => 2 * (float)Math.PI * Radius;
    }

    class Trapezoid : IShape
    {
        public float Base1 { get; }
        public float Base2 { get; }
        public float Height { get; }
        public float Side1 { get; }
        public float Side2 { get; }

        public Trapezoid(float base1, float base2, float height, float side1, float side2)
        {
            Base1 = base1;
            Base2 = base2;
            Height = height;
            Side1 = side1;
            Side2 = side2;
        }

        public float Area() => ((Base1 + Base2) / 2) * Height;

        public float Perimeter() => Base1 + Base2 + Side1 + Side2;
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(
            "Which shape do you want to find the area or perimeter of? (circle, square, rectangle, trapezoid)"
        );
        string shape = Console.ReadLine().ToLower();

        Console.WriteLine("Which calculation type: area or perimeter?");
        string calculationType = Console.ReadLine().ToLower();

        IShape selectedShape = null;

        switch (shape)
        {
            case "rectangle":
                Console.WriteLine("Enter the height of rectangle:");
                float rectHeight = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter the width of rectangle:");
                float rectWidth = float.Parse(Console.ReadLine());
                selectedShape = new Rectangle(rectHeight, rectWidth);
                break;

            case "square":
                Console.WriteLine("Enter the side length of square:");
                float side = float.Parse(Console.ReadLine());
                selectedShape = new Square(side);
                break;

            case "circle":
                Console.WriteLine("Enter the radius of the circle:");
                float radius = float.Parse(Console.ReadLine());
                selectedShape = new Circle(radius);
                break;

            case "trapezoid":
                if (calculationType == "area")
                {
                    Console.WriteLine("Enter base 1 of trapezoid:");
                    float base1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter base 2 of trapezoid:");
                    float base2 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the height of trapezoid:");
                    float height = float.Parse(Console.ReadLine());
                    // For area, sides are not needed, set to 0
                    selectedShape = new Trapezoid(base1, base2, height, 0, 0);
                }
                else
                {
                    Console.WriteLine("Enter base 1 of trapezoid:");
                    float base1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter base 2 of trapezoid:");
                    float base2 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter side 1 of trapezoid:");
                    float side1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter side 2 of trapezoid:");
                    float side2 = float.Parse(Console.ReadLine());
                    // For perimeter, height is not needed, set to 0
                    selectedShape = new Trapezoid(base1, base2, 0, side1, side2);
                }
                break;
            default:
                Console.WriteLine("Enter a valid shape (square, rectangle, circle, trapezoid)");
                return;
        }
        float result = 0;
        if (selectedShape != null)
        {
            if (calculationType == "area")
                result = selectedShape.Area();
            else if (calculationType == "perimeter")
                result = selectedShape.Perimeter();
            else
            {
                Console.WriteLine("Invalid calculation type.");
                return;
            }
            Console.WriteLine($"The {calculationType} is {result}");
        }
    }
}
