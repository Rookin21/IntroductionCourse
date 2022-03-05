using System;

namespace IntroductionCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вывод сообщения пользователю
            Console.WriteLine("Введите целое число");

            // Ввод числа пользователем
            int number = Convert.ToInt32(Console.ReadLine());

            // Вычисление остатка от деления
            int parity = number % 2;

            // Определение является ли число четным
            if (parity == 0)
            {
                Console.WriteLine("Введенное число является четным");
            }
            else
            {
                Console.WriteLine("Введенное число не является четным");
            }

            // Ожидание нажатия клвавиши Enter
            Console.ReadLine();

        }
    }
}
