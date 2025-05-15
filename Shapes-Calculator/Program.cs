namespace Shapes_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer;
            float result = 0;

            Console.WriteLine("which shape do you want to find the area of? (square, rectangle, circle, trapezoid)");

            answer = Console.ReadLine().ToLower();

            if (answer == "rectangle")
            {
                Console.WriteLine("enter the height of rectangle");
                // convert user input into float
                float height = float.Parse(Console.ReadLine());

                Console.WriteLine("enter the width of rectangle");
                // convert user input into float
                float width = float.Parse(Console.ReadLine());

                result = height * width;
            }
            else if (answer == "circle")
            {
                Console.WriteLine("enter radius of the circle");
                float radius = float.Parse(Console.ReadLine());

                result = (float)Math.PI * (radius * radius);
            }
            else if (answer == "square")
            {
                Console.WriteLine("enter the height of square");
                float height = float.Parse((Console.ReadLine()));

                Console.WriteLine("enter the width of square");
                float width = float.Parse((Console.ReadLine()));

                result = height * width;
            }
            else if (answer == "trapezoid")
            {
                Console.WriteLine("enter base 1 of trapezoid");
                float base1 = float.Parse((Console.ReadLine()));

                Console.WriteLine("enter base 2 of trapezoid");
                float base2 = float.Parse((Console.ReadLine()));

                Console.WriteLine("enter the height of trapezoid");
                float height = float.Parse((Console.ReadLine()));

                result = ((base1 + base2) / 2) * height;
            } else
            {
                Console.WriteLine("enter a valid shape (square, rectangle, circle, trapezoid)");
            }
                Console.WriteLine("the result is " + result);
        }
    }
}
