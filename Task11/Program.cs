using System;
/*
* Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
*/
namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = 0;
            Console.WriteLine("Get number between 10 - 99");
            Number = Convert.ToInt32(Console.ReadLine()); ;
            if (Number >= 100 && Number <= 999)
            {
                int FirstDigit = Number % 10;
                int SecondDigit = Number / 10;
                int DigitWithoutSeconNumber = (ThirdDigit * 10) + LastDigit;
                Console.WriteLine("Number Without Second Digit  " + DigitWithoutSeconNumber);
            }
            else
            {
                Console.WriteLine("Number not between 10 - 99");
            }
        }
    }
}
