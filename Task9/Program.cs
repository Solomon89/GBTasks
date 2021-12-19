using System;
/*
* Показать последнюю цифру трёхзначного числа
*/
namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = 0;
            Console.WriteLine("Get number between 100 - 999" );
            Number = Convert.ToInt32(Console.ReadLine());
            if (Number >= 100 && Number <= 999)
            {
                int lastDigit = Number % 10;
                Console.WriteLine("Last digit is " + lastDigit);
            }
            else
            {
                Console.WriteLine("Number not between 100 - 999" );
            }
        }
    }
}
