using System;
using System.IO;

namespace IntroductionCourse
{
    class Program
    {
        static void Main()
        {
            string filename = Input_filename(); // Ввод названия файла
            string path = Input_path();         // Ввод пути
            Output(filename, path);             // записываем путь в файл
            string arr = Reverse(path);         // переворачиваем путь
            Output_reverse(filename, path, arr);// записываем перевернутое название в файл
            Console.Read();
        }

        static void Output(string filename, string path)
        {
            File.AppendAllText($"{path}/{filename}.txt", $"\n{path}");
        }

        static void Output_reverse(string filename, string path, string arr)
        {
            File.AppendAllText($"{path}/{filename}.txt", $"\n{arr}");
        }

        static string Reverse (string path)
        {
            char[] arr = path.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        static string Input_filename ()
        {
            Console.WriteLine("Введите название файла");
            string filename = Console.ReadLine();
            return filename;
        }

        static string Input_path ()
        {
            Console.WriteLine("Введите путь для сохранения " +
                              " в формате: D:/Homework ");
            string path = Console.ReadLine();
            return path;
        }            
    }
}
