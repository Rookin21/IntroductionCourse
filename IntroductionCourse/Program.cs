using System;
using System.Diagnostics;

namespace IntroductionCourse
{
    class Program
    {
        static void Main()
        {
            View();         // Метод для просмотра всех процессов
            Procs_kill();   // Метод для завершения процесса, путем выбора ID

            Console.Read(); 
        }

        static void Procs_kill ()
        {
            // Выбор ID процесса
            Console.WriteLine("Выберите ID процесса, который хотите завершить: ");
            int id = Convert.ToInt32(Console.ReadLine());
            // Завершение процесса выбранного ID
            Process Id = Process.GetProcessById(id);
            Id.Kill();
            // Ожидание заверешения процесса
            Id.WaitForExit();
            // Сообщение при успешном/не успешном заверешении
            if (Id.HasExited)
            {
                Console.WriteLine("Работа процесса завершена");
            }
            else
            {
                Console.WriteLine("Произошла ошибка при завершении процесса");
            }
        }

        static void View ()
        {
            Process[] procs = Process.GetProcesses();

            foreach (Process p in procs)
            {
                Console.WriteLine($"ID: {p.Id}  Name: {p.ProcessName}");
            }
        }
    }
}
