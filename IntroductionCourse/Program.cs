using System;

namespace IntroductionCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[10, 10];                    // Создание массива размерность 10х10

            for (int i = 0; i < matrix.GetLength(0); i++)       
            {                                                   // Создание многомерного массива
                for (int j = 0; j < matrix.GetLength(1); j++)   
                {
                    matrix[i, j] = 1;                           // Задаем значения для вывода в массиве = 1
                    Console.WriteLine($"{new string(' ', i)}{matrix[i, j]}");   // Создаем пустые строки для вывода строк по диагонали                      
                    break;
                }
            }
            Console.ReadLine();

        }
    }
}
