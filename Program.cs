using System;
namespace MathsProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool control = true;
            Console.WriteLine("Welcome to Maths Class App");
            do
            {
                Methods.DoMethod();
                Console.Write("Do you want to continue (y/n) : ");
                if (Console.ReadLine() == "n")
                {
                    control = false;
                }
            } while (control);
        }
    }
}
