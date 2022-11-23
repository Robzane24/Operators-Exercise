using System.Diagnostics.CodeAnalysis;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise one

            int a = 11;
            int b = 2;
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");

            //Exercise two
            Console.WriteLine("Please enter the radius of your circle:");

            var radius = double.Parse(Console.ReadLine());

            Console.WriteLine(AreaOfCircle(radius));
        }
        public static double AreaOfCircle(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
    }
}
