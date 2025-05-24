namespace Shapes_Calculator
{
    internal class Shapes1
    {
        static void Main(string[] args)
        {
            string shape;
            string calculationType;
            float result = 0;

            Console.WriteLine("which shape do you want to find the area of? (square, rectangle, circle, trapezoid)");
            shape = Console.ReadLine().ToLower();

            Console.WriteLine("Which calculation type: area or perimeter?");
            calculationType = Console.ReadLine().ToLower();

            if (shape == "rectangle")
            {
                Console.WriteLine("enter the height of rectangle");
                // convert user input into float
                float height = float.Parse(Console.ReadLine());

                Console.WriteLine("enter the width of rectangle");
                // convert user input into float
                float width = float.Parse(Console.ReadLine());

                if (calculationType == "area")
                {
                    result = height * width;
                }
                else if (calculationType == "perimeter")
                {
                    result = 2 *  (height * width);
                }   
            }
            else if (shape == "circle")
            {
                Console.WriteLine("enter radius of the circle");
                float radius = float.Parse(Console.ReadLine());

                if (calculationType == "area")
                {
                    result = (float)Math.PI * (radius * radius);
                }
                else if (calculationType == "perimeter")
                {
                    result = 2 *( (float)Math.PI * radius);
                }
            }
            else if (shape == "square")
            {
                Console.WriteLine("enter the side length of square");
                float sides = float.Parse((Console.ReadLine()));


                if (calculationType == "area")
                {
                    result = sides * sides;
                }
                else if (calculationType == "perimeter")
                {
                    result = 4 * sides;
                }
            }
            else if (shape == "trapezoid")
            {
                if (calculationType == "area")
                {
                Console.WriteLine("enter base 1 of trapezoid");
                float base1 = float.Parse((Console.ReadLine()));

                Console.WriteLine("enter base 2 of trapezoid");
                float base2 = float.Parse((Console.ReadLine()));

                Console.WriteLine("enter the height of trapezoid");
                float height = float.Parse((Console.ReadLine()));

                result = ((base1 + base2) / 2) * height;

                }
                else if (calculationType == "perimeter")
                {
                    Console.WriteLine("Enter base 1 of the trapezoid:");
                    float base1 = float.Parse(Console.ReadLine());

                    Console.WriteLine("Enter base 2 of the trapezoid:");
                    float base2 = float.Parse(Console.ReadLine());

                    Console.WriteLine("Enter side 1 of the trapezoid:");
                    float side1 = float.Parse(Console.ReadLine());

                    Console.WriteLine("Enter side 2 of the trapezoid:");
                    float side2 = float.Parse(Console.ReadLine());

                    result = base1 + base2 + side1 + side2;
                }
            } else
            {
                Console.WriteLine("enter a valid shape (square, rectangle, circle, trapezoid)");
            }
                Console.WriteLine("the result is " + result);
        }
    }
}
