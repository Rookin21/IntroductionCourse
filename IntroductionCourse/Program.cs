using System;

namespace IntroductionCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = GetFirstName();  // Вызов метода запроса Имени
            string lastName = GetLastName();    // Вызов метода запроса Фамилии
            string patronymic = GetPatronymic();    // Вызов метода запроса Фамилии
            string FullName = GetFullName(firstName, lastName, patronymic); // Вызов метода вызова объединенной строки
            Console.WriteLine(FullName); // Вывод данных на консоль
        }
                            
        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return $"Привет, {lastName} {firstName} {patronymic}!";
        }

        static string GetLastName()
        {
            Console.Write("Фамилия: ");
            string lastName = Console.ReadLine();
            return lastName;
        }

        static string GetFirstName()
        {
            Console.Write("Имя: ");
            string firstName = Console.ReadLine();
            return firstName;
        }

        static string GetPatronymic()
        {
            Console.Write("Отчество: ");
            string patronymic = Console.ReadLine();
            return patronymic;
        }
    }
}
