namespace Shapes_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer;
            float result;

            Console.WriteLine("which shape do you want to find the area of?");

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
        }
    }
}
