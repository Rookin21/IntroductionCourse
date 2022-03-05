using System;

namespace IntroductionCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимальную температуру за сутки");
            float minTemp = Convert.ToInt64(Console.ReadLine());            // Ввод пользователем значение минимальной температуры

            Console.WriteLine("Введите максимальную температуру за сутки");
            float maxTemp = Convert.ToInt64(Console.ReadLine());            // Ввод пользователем значение максимальной температуры

            float averageTemp = (minTemp + maxTemp) / 2;                    // Вычисление среднесуточного значения температуры
            Console.WriteLine($"Среднесуточная температура: {averageTemp}");

            Console.WriteLine("Введите порядковый номер месяца");
            int month = Convert.ToInt32(Console.ReadLine());                // Ввод пользователем номера месяца

            // Проверка на корректность ввода номера месяца
            if (month > 12)
            {
                Console.WriteLine("Вы ввели некорректный номер месяца");
                return;
            }

            // Обработка условия для вывода сообщения
            if ((month == 12 || month == 1 || month == 2) && (averageTemp > 0))
            {
                Console.WriteLine("Дождливая погода");
            }
            else
            {
                return;
            }

            Console.Read();
        }
    }
}
