using System;
using System.IO;

namespace IntroductionCourse
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите текст: ");
            string text = Console.ReadLine();
            string path = "D:/Homework_GB/homework_lesson5_1.txt";
            File.WriteAllText(path, text);
        }
    }
}
