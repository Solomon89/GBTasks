using System;
/*
* Показать вторую цифру трёхзначного числа
*/
namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = 0;
            Console.WriteLine("Get number between 100 - 999" );
            Number = Convert.ToInt32(Console.ReadLine());;
            if (Number >= 100 && Number <= 999)
            {
                int DecreaseByTen = Number / 10;
                int LastDigit = DecreaseByTen % 10;
                Console.WriteLine("Second digit is " + LastDigit );
            }
            else
            {
                Console.WriteLine("Number not between 100 - 999" );
            }
        }
    }
}
