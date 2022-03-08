using System;

namespace IntroductionCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание массива
            string[,] phoneBook = 
            { 
                { "Александр", " +1 111 111 11 11" },
                { "Анатолий", " +2 222 222 22 22" },
                { "Евгений", " +3 333 333 33 33" },
                { "Максим", " +4 444 444 44 44" },
                { "Олег", " +5 555 555 55 55" }
            };

            // Запуск цикла для вывода данных массива
            for (int i = 0; i < phoneBook.GetLength(0); i++)
            {
                for (int j = 0; j < phoneBook.GetLength(1); j++)
                {
                    Console.Write($"{phoneBook[i,j]}");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
            
        }
    }
}
