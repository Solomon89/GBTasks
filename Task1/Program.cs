using System;

/*
* По двум заданным числам проверять является ли первое квадратом второго
*/
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int FirstNumber = 0;
            int SecondNumber = 0;
            Console.WriteLine("Get first numbers");
            FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Get second numbers");
            SecondNumber = Convert.ToInt32(Console.ReadLine());
            if (FirstNumber * FirstNumber == SecondNumber)
            {
                Console.WriteLine("First number is square of second");
            }
            else
            {
                Console.WriteLine("First number is square of second");
            }
        }
    }
}
