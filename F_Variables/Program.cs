using System;

namespace F_Variables
{
    /// <summary>
    /// Пользователь вводит 4 числа (X1, Y1, X2, Y2), описывающие координаты 2-х точек
    /// на координатной плоскости. Выведите уравнение прямой в формате Y=AX+B, 
    /// проходящей через эти точки.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string firstInput;
            string secondInput;
            string thirdInput;
            string fourthInput;

            Console.WriteLine("Введите 4 числа (X1, Y1, X2, Y2)");

            Console.WriteLine("Первое число (X1):");
            firstInput = Console.ReadLine();
            double x1 = Convert.ToDouble(firstInput);

            Console.WriteLine("Второе число (Y1):");
            secondInput = Console.ReadLine();
            double y1 = Convert.ToDouble(secondInput);

            Console.WriteLine("Третье число (X2):");
            thirdInput = Console.ReadLine();
            double x2 = Convert.ToDouble(thirdInput);

            Console.WriteLine("Четвертое число (Y2):");
            fourthInput = Console.ReadLine();
            double y2 = Convert.ToDouble(fourthInput);

            void PlacePoint(double a, double b, double c, double d)
            {
                var k = (b - d) / (a - c);
                var s = d - k * c;

                Console.WriteLine($"Y={k}x + {s}");
            }

            PlacePoint(x1, y1, x2, y2);

            Console.ReadKey();
        }
    }
}
