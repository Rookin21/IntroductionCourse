using System;

namespace IntroductionCourse
{
    class Program
    {
        static void Main()
        {
            int number = userInput();   // Ввод пользователем числа 
            Check(number);              // Проверка корректности ввода
            OutInfo(number);            // Вывод
        }

        static void OutInfo(int number)
        {
            // Вывод месяца
            switch (number)
            {
                case 1:
                    Console.WriteLine(Season.Winter);
                    break;
                case 2: goto case 1;
                case 3:
                    Console.WriteLine(Season.Spring);
                    break;
                case 4: goto case 3;
                case 5: goto case 3;
                case 6:
                    Console.WriteLine(Season.Summer);
                    break;
                case 7: goto case 6;
                case 8: goto case 6;
                case 9:
                    Console.WriteLine(Season.Autumn);
                    break;
                case 10: goto case 9;
                case 11: goto case 9;
                case 12: goto case 1;
            }
            Console.ReadKey();
        }

        static void Check (int number)
        {
            // Проверка корректности ввода. 
            if (number > 12 || number <= 0)
            {
                Console.WriteLine("Ошибка: введите число от 1 до 12");
                Main();
            }
        }

        static int userInput()
        {
            Console.WriteLine("Введите номер месяца");
            return Convert.ToInt32(Console.ReadLine());           
        }

    }

    enum Season
    {
        Winter,
        Spring,
        Summer,
        Autumn
    }
}
