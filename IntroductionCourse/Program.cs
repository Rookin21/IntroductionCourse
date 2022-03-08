using System;

namespace IntroductionCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод пользователем текста
            string userText = Console.ReadLine();
            
            // Текст разбиваем на символы
            char [] reverseText = userText.ToCharArray();

            // Реверсируем данные
            Array.Reverse(reverseText);

            // Выводим на экран
            for (int i = 0; i < reverseText.Length; i++)
            {
                Console.Write(reverseText[i]);
            }

            Console.Read();
        }
    }
}
