using System;

namespace IntroductionCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            char num1 = ' ';

            char[,] seaBattle =
            {
                { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ж', 'З', 'И', 'К' },
                { 'X', 'O', 'O', 'O', 'X', 'O', 'O', 'O', 'O', 'X' },
                { 'О', 'O', 'O', 'O', 'X', 'O', 'O', 'O', 'O', 'О' },
                { 'О', 'O', 'O', 'O', 'O', 'O', 'O', 'X', 'X', 'X' },
                { 'О', 'X', 'X', 'X', 'X', 'O', 'O', 'O', 'O', 'O' },
                { 'О', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O' },
                { 'X', 'O', 'O', 'O', 'O', 'X', 'O', 'O', 'X', 'O' },
                { 'X', 'O', 'O', 'O', 'O', 'X', 'O', 'O', 'X', 'O' },
                { 'О', 'O', 'O', 'O', 'O', 'X', 'O', 'O', 'O', 'O' },
                { 'О', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O' },
                { 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'X' },
            };

            for (int i = 0; i < seaBattle.GetLength(0); i++)
            {
                for (int j = 0; j < seaBattle.GetLength(1); j++)
                {
                    Console.Write($"{seaBattle[i, j]}");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
