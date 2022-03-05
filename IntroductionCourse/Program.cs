using System;

namespace IntroductionCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вывод на консоль сообщения
            Console.WriteLine("Введите имя пользователя:");

            // Ввод пользователем имени
            string user_name = Console.ReadLine();

            // Вывод сообщения используя структуру текущей даты
            Console.WriteLine($"Привет, {user_name}, сегодня {DateTime.Today.ToShortDateString()}");

            // Ожидание нажатия клавиши Enter
            Console.Read();

        }
    }
}
