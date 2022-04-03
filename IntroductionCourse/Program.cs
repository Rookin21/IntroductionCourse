using System;

namespace IntroductionCourse
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите крайнее порядковое число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Fibonachi(number);
            Console.WriteLine($"Число Фибоначчи: {Fibonachi(number)}");
            Console.ReadKey();
        }

        static int Fibonachi(int number)
        {
            if (number == 0 || number == 1) return number;

            return Fibonachi(number - 1) + Fibonachi(number - 2);
        }
    }
}
