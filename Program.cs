using System;

namespace Method_Exercise
{
    internal class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string band = Console.ReadLine();
            Console.WriteLine($"{name} went on a long walk one day, it began as just a way to get air but along the way they actually ran into {band} at a park.');
            Console.WriteLine($"{band} was very cool and even asked {name} about what they should name their new song. {name} knew exactly what the song would be called.");
            Console.WriteLine($"The song would later be known as {color} {animal}, and it was surprisingly a very popular song.");

            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"the sum is: {sum}");

            Console.WriteLine("Give me a number to multiply");
            num1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Give me a number to multiply with the first");
            num2 = int.Parse(Console.ReadLine());

            int product = Multiply(num1, num2);
            Console.WriteLine($"the product is: {product});
 
            Console.WriteLine("Give me a number to start");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to subtract from the first one");
            int num2 = int.Parse(Console.ReadLine());

            int difference = Difference(num1, num2);
            Console.WriteLine($"the difference is: {difference}");

            Console.WriteLine("Give me a number to divide");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to divide from the first one");
            int num2 = int.Parse(Console.ReadLine());

            int quotient = Quotient(num1, num2);
            Console.WriteLine($"the quotient is: {quotient}");

            Console.WriteLine("Give me a number for modulus");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me another number for modulus");
            int num2 = int.Parse(Console.ReadLine());

            int abs = Abs(num1, num2);
            Console.WriteLine($"the modulus is: {abs}");


            {
                
        }
    }

        public static int Abs(int num1, int num2)
        {
            return num1 % num2;
        }

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Quotient(int num1, int num2)
        {
            return num1 / num2;
        }

        public static int Difference(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
    }
