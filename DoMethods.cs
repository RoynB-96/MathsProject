using System;
namespace MathsProject
{
    public static class Methods
    {
        public static double[] InputArray(params double[] _array)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] = Checks.CheckNumber();
            }
            return _array;
        }
        public static void PrintArray(double[] _array)
        {
            foreach (double element in _array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
        public static void ShowMenu()
        {
            Console.WriteLine("1. FindMin");
            Console.WriteLine("2. FindMax");
            Console.WriteLine("3. DoFactorial");
            Console.WriteLine("4. DoSort");
        }
        public static void DoMethod()
        {
            double number1;
            double number2;
            uint number;
            uint size;
            bool check;
            Console.WriteLine("Please choose a Method to use :)");
            Console.WriteLine("Available Methods");
            do
            {
                check = false;
                ShowMenu();
                switch (Checks.CheckChoice())
                {
                    case 1:
                        number1 = Checks.CheckFirstNumber();
                        number2 = Checks.CheckSecondNumber();
                        Console.WriteLine("Minimum Value: " + Maths.FindMin(number1, number2));
                        break;
                    case 2:
                        number1 = Checks.CheckFirstNumber();
                        number2 = Checks.CheckSecondNumber();
                        Console.WriteLine("Maximum Value: " + Maths.FindMax(number1, number2));
                        break;
                    case 3:
                        number = Checks.CheckFactorial();
                        Console.WriteLine("Factorial: " + Maths.DoFactorial(number));
                        break;
                    case 4:
                        size = Checks.CheckSize();
                        double[] array = new double[size];
                        InputArray(array);
                        Console.Write("Initial Array: ");
                        PrintArray(array);
                        Console.Write("Sorted Array: ");
                        PrintArray(Maths.DoSort(array));
                        break;
                    default:
                        check = true;
                        Console.WriteLine("Error! Please input a valid integer.");
                        Console.WriteLine("Valid Methods");
                        break;
                }
            } while (check);
        }
    }
}
