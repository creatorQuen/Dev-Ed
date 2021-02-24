using System;

namespace C_Variables
{
    /// <summary>
    /// Пользователь вводит 2 числа (A и B). Выведите в консоль результат деления A на B и остаток 
    /// от деления.
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

            double resultDivision = firstNumber / secondNumber;
            Console.WriteLine($"Результат операции деления А и В = {resultDivision}");
            
            double resultRemainder = firstNumber % secondNumber;
            Console.WriteLine($"Результат остаток от деления А и В = {resultRemainder}");

            Console.ReadKey();
        }
    }
}
