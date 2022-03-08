using System;

namespace IntroductionCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод пользователем текста
            string userText = Console.ReadLine();
            
            char [] reverseText = userText.ToCharArray();

            Array.Reverse(reverseText);

            for (int i = 0; i < reverseText.Length; i++)
            {
                Console.Write(reverseText[i]);
            }

            Console.Read();
        }
    }
}
