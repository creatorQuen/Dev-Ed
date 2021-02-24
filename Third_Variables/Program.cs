using System;

namespace D_Variables
{
    /// <summary>
    /// Пользователь вводит 3 числа (A, B и С). Выведите в консоль решение(значение X)
    /// линейного уравнения стандартного вида, где A*X+B=C.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string firstInput;
            string secondInput;
            string thirdInput;

            Console.WriteLine("Введите 3 числа");

            Console.WriteLine("Первое число (A):");
            firstInput = Console.ReadLine();
            double firstNumber = Convert.ToDouble(firstInput);

            Console.WriteLine("Второе число (B):");
            secondInput = Console.ReadLine();
            double secondNumber = Convert.ToDouble(secondInput);

            Console.WriteLine("Третье число (С):");
            thirdInput = Console.ReadLine();
            double thirdNumber = Convert.ToDouble(thirdInput);

            void LinearEquation(double a, double b, double c)
            {
                double x = (c - b) / a;
                Console.WriteLine($"Решение линейного уравнения стандартного вида, где A*X+B=C: {x}"); 
            }

            LinearEquation(firstNumber, secondNumber, thirdNumber);

            Console.ReadKey();
        }


    }
}
