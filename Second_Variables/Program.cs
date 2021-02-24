using System;

namespace B_Variables
{
    /// <summary>
    /// Пользователь вводит 2 значения(A и B). Поменяйте содержимое переменных A и B местами.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string firstInput;
            string secondInput;

            Console.WriteLine("Введите 2 значения");

            Console.WriteLine("Первое значения (A):");
            firstInput = Console.ReadLine();

            Console.WriteLine("Второе значение (B):");
            secondInput = Console.ReadLine();

            string changer;
            changer = firstInput;
            firstInput = secondInput;
            secondInput = changer;

            Console.WriteLine("Теперь значения А и В поменялись местами");

            // Чтобы вывести значения для проверки.
            Console.WriteLine("Проверка:");
            Console.WriteLine($"A: {firstInput}");
            Console.WriteLine($"B: {secondInput}");

        }
    }
}
