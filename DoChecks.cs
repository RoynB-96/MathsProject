using System;
namespace MathsProject
{
    public static class Checks
    {
        public static double CheckNumber()
        {
            Console.Write("Input a number: ");
            string input = Console.ReadLine();
            double value;
            while (!double.TryParse(input, out value))
            {
                Console.Write("Error! Please input a double number: ");
                input = Console.ReadLine();
            }
            return value;
        }
        public static double CheckFirstNumber()
        {
            Console.Write("Input the first number: ");
            string input = Console.ReadLine();
            double value;
            while (!double.TryParse(input, out value))
            {
                Console.Write("Error! Please input a double number: ");
                input = Console.ReadLine();
            }
            return value;
        }
        public static double CheckSecondNumber()
        {
            Console.Write("Input the second number: ");
            string input = Console.ReadLine();
            double value;
            while (!double.TryParse(input, out value))
            {
                Console.Write("Error! Please input a double number: ");
                input = Console.ReadLine();
            }
            return value;
        }
        public static uint CheckFactorial()
        {
            Console.Write("Input a number: ");
            string input = Console.ReadLine();
            uint value;
            while (!uint.TryParse(input, out value))
            {
                Console.Write("Error! Please input a natural number: ");
                input = Console.ReadLine();
            }
            return value;
        }
        public static uint CheckSize()
        {
            Console.Write("Input an array size: ");
            string input = Console.ReadLine();
            uint value;
            while (!uint.TryParse(input, out value))
            {
                Console.Write("Error! Please input a valid size: ");
                input = Console.ReadLine();
            }
            if (value == 0)
            {
                do
                {
                    Console.WriteLine("Error! Please input a valid size.");
                    value = CheckSize();
                } while (value == 0);
            }
            return value;
        }
        public static int CheckChoice()
        {
            Console.Write("Your Choice: ");
            string input = Console.ReadLine();
            int value;
            while (!int.TryParse(input, out value))
            {
                Console.Write("Error! Please input an integer number: ");
                input = Console.ReadLine();
            }
            return value;
        }
    }
}
