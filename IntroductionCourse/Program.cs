using System;

namespace IntroductionCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            int receipt = 4201; // Номер чека

            string surnameOfCashier = "Иванов"; // Фамилия кассира
            // Названия товаров
            string nameFirstProduct = "Кирпич пустотелый одинарный М-150";
            string nameSecondProduct = "Цемент ПЦ-400 Д 20 (мешках)";
            string nameThirdProduct = "Щебень фракция 20x40 т.";
            string nameFourthProduct = "Гвозди жидкие/ 310 мл";
            // Количество товаров
            int countFirstProduct = 800;
            int countThirdProduct = 5;
            int countFourthProduct = 4;
            // Сумма за одну единицу товара
            double priceFirstProduct = 10.22;
            double priceSecondProduct = 5400.00;
            double priceThirdProduct = 480.00;
            double priceFourthProduct = 163.00;
            // Сумма товара
            double sumFirst = Math.Round((countFirstProduct * priceFirstProduct),2);
            double sumSecond = Math.Round(priceSecondProduct,2);
            double sumThird = Math.Round((countThirdProduct * priceThirdProduct),2);
            double sumFourth = Math.Round((countFourthProduct * priceFourthProduct),2);
            // Общий итог
            double sumAll = Math.Round((sumFirst + sumSecond + sumThird + sumFourth), 2);

            // Настройка даты
            DateTime date = new DateTime(2022, 6, 3, 10, 47, 42);

            // Вывод информации на консоль
            Console.WriteLine("\t ООО 'СуперЧек.ru'");
            Console.WriteLine($"\t    Чек № {receipt}");
            Console.WriteLine($"\t  Кассир: {surnameOfCashier}");

            Console.WriteLine($"1.{nameFirstProduct}" +
                              $"\n{countFirstProduct} X {priceFirstProduct}" +
                              $"\nСтоимость......................{sumFirst}");
            Console.WriteLine($"2.{nameSecondProduct}" +
                              $"\nСтоимость......................{sumSecond}");
            Console.WriteLine($"3.{nameThirdProduct}" +
                              $"\n{countThirdProduct} X {priceThirdProduct}" +
                              $"\nСтоимость......................{sumThird}");
            Console.WriteLine($"4.{nameFourthProduct}" +
                              $"\n{countFourthProduct} X {priceFourthProduct}" +
                              $"\nСтоимость......................{sumFourth}");
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Всего........................{sumAll}");

            Console.WriteLine($"ККМ 00000000 ИНН 00000000000 №{receipt}");
            Console.WriteLine($"{date.ToString("dd.MM.yy")} {date.ToString("HH:mm:ss")}" +
                              $"\t    {surnameOfCashier}");
            Console.WriteLine("ПРОДАЖА \t \t     №2890");
            Console.WriteLine($"ИТОГ \t \t \t    ={sumAll}");

            Console.ReadLine(); 
        }
    }
}
