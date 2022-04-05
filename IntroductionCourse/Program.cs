using System;
using System.IO;

namespace IntroductionCourse
{
    class Program
    {
        static void Main()
        {
            string path = "D:/Homework_GB/startup.txt";
            string time = DateTime.Now.ToString("HH:mm:ss");
            Console.WriteLine($"Текущее время: {time}");

            File.AppendAllText(path, $"\n{time}");
            Console.WriteLine("Информация записана в файл");
            Console.Read();
        }
    }
}
