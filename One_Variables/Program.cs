using System;

namespace A_Variables
{
    /// <summary>
    /// Пользователь вводит 2 числа (A и B). Выведите в консоль решение (5*A+B^2) / (B-A)
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            string firstInput;
            string secondInput;

            Console.WriteLine("Введите 2 числа");

            Console.WriteLine("Первое число (A):");
            firstInput = Console.ReadLine();
            double firstNumber = Convert.ToDouble(firstInput);

            Console.WriteLine("Второе число (B):");
            secondInput = Console.ReadLine();
            double secondNumber = Convert.ToDouble(secondInput);

            if (secondNumber - firstNumber == 0)
            {
                Console.WriteLine("!!! Число A и B не должны быть равны");
                Console.ReadKey();
            }
            else
            {
                double resultSolution = (5 * firstNumber + Math.Pow(secondNumber, 2)) / (secondNumber - firstNumber);
                Console.WriteLine($"Результат операции с числами А и В:{resultSolution}");
            }


            Console.ReadKey();
        }
    }
}
