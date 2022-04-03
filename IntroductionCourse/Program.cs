using System;
using System.Linq;

namespace IntroductionCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа через пробел");
            // Разбиение введенных чисел на отдельные составляющие
            int userNumbers = Sum(Console.ReadLine().Split().Sum(int.Parse));

            Console.WriteLine(userNumbers);
        }

        // Метод с использование ключевого слова params для суммы введенных чисел
        static int Sum(params int[] values)
        {
            int sum = 0;
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }
            return sum;
        }
    }
}
