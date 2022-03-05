using System;

namespace IntroductionCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вывод сообщения пользователю
            Console.WriteLine("Введите минимальную температуру за сутки");

            // Ввод пользователем значение минимальной температуры
            float minTemp = Convert.ToInt64(Console.ReadLine());

            // Вывод сообщения пользователю
            Console.WriteLine("Введите максимальную температуру за сутки");

            // Ввод пользователем значение максимальной температуры
            float maxTemp = Convert.ToInt64(Console.ReadLine());

            // Вычисление среднесуточного значения температуры
            float averageTemp = (minTemp + maxTemp) / 2;

            // Вывод сообщения пользователю со значением
            Console.WriteLine($"Среднесуточная температура за сутки равна: {averageTemp}");

            // Ожидание нажатия клавиши Enter
            Console.Read();
        }
    }
}
