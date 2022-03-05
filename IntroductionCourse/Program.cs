using System;

namespace IntroductionCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Переменная для вывода названия месяца
            string monthTitle = " ";

            // Вывод пользователю сообщения
            Console.WriteLine("Введите номер месяца от 1 до 12");

            // Ввод пользователем порядковый номер месяца
            int numberOfMonth = Convert.ToInt32(Console.ReadLine());

            // Определение месяца
            switch (numberOfMonth)
            {
                case 1:
                    monthTitle = "Январь";
                    break;
                case 2:
                    monthTitle = "Февраль";
                    break;
                case 3:
                    monthTitle = "Март";
                    break;
                case 4:
                    monthTitle = "Апрель";
                    break;
                case 5:
                    monthTitle = "Май";
                    break;
                case 6:
                    monthTitle = "Июнь";
                    break;
                case 7:
                    monthTitle = "Июль";
                    break;
                case 8:
                    monthTitle = "Август";
                    break;
                case 9:
                    monthTitle = "Сентябрь";
                    break;
                case 10:
                    monthTitle = "Октябрь";
                    break;
                case 11:
                    monthTitle = "Ноябрь";
                    break;
                case 12:
                    monthTitle = "Декабрь";
                    break;
            }

            // Вывод результирующего сообщения пользователю
            Console.WriteLine($"{monthTitle} - соответствует номеру месяца, который вы выбрали");
            // Ожидание нажатия клвавиши Enter
            Console.ReadLine();
        }
    }
}
