using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace OperatorExercise
{
    public class Program
    {
        public static double AreaofCircle(double radius)
        {
            double area = Math.PI * (radius * radius);
            //other way of doing powers Math.Pow(radius, 2);
            return area;
        }


        static void Main(string[] args)
        {
            //Exercise 1

            // Addition Operator
            int x = 20;
            int y = 10;
            x += y;
            Console.WriteLine(x);

            // Subtraction Operator 
            x = 13;
            y = 3;
            x -= y;
            Console.WriteLine(x);

            // Multiplication Operator
            x = 15;
            y = 5;
            x *= y;
            Console.WriteLine(x);

            // Division Operator 
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;

            if (a == 17 && b == 4)
            {
                Console.WriteLine($"17/4 is {quotient} remainder {remainder}");
            }

            // Exercise 2 

            Console.WriteLine("What is the radius of the circle?");
            var radius = double.Parse(Console.ReadLine());

            double area = AreaofCircle(radius);
            Console.WriteLine($"The area of a circle with radius of {radius} is {area}");

            

        }


    }
}

