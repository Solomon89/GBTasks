using System;
/*
* Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
*/
namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = 0;
            Console.WriteLine("Get number between 10 - 99");
            Number = Convert.ToInt32(Console.ReadLine()); ;
            if (Number >= 10 && Number <= 99)
            {
                int SecondDigit = Number % 10;
                int FirstDigit = Number / 10;
                if (FirstDigit > SecondDigit)
                {
                    Console.WriteLine("First digit is bigger");
                }
                else
                {
                    Console.WriteLine("Second digit is bigger");
                }
            }
            else
            {
                Console.WriteLine("Number not between 10 - 99");
            }
        }
    }
}
