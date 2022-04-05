using System;
using System.IO;
using System.Text;

namespace IntroductionCourse
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите произвольной набор чисел 0...255");
            string num = Console.ReadLine();

            // Создание файла
            using (FileStream fs = new FileStream("D:/homework.bin", FileMode.Create))
            {
                // Вызов класса для бинарной записи
                using (BinaryWriter bw = new BinaryWriter(fs, Encoding.Default))
                {
                    // Запись
                    bw.Write(num);
                }
            }
            // Открытие файла
            using (FileStream fs = new FileStream("D://HomeWork_GB/homework.bin", FileMode.Open))
            {
                // Вызов класса для бинарного чтения
                using (BinaryReader br = new BinaryReader(fs, Encoding.Default))
                {
                    // Считывание
                    string num2 = br.ReadString();

                    // Вывести прочитание данные на экран для контроля
                    Console.WriteLine("Чтение из файла: {0}", num2);
                }
            }
            Console.Read();
        }
    }
}
