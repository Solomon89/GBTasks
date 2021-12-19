using System;

namespace Task2
{
    /*
    * Даны два числа. Показать большее и меньшее число
    */
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
            if (FirstNumber > SecondNumber)
            {
                Console.WriteLine("Greater number: " + FirstNumber);
                Console.WriteLine("Smaller number: " + SecondNumber);
            }
            else
            {
                Console.WriteLine("Greater number: " + SecondNumber);
                Console.WriteLine("Smaller number: " + FirstNumber);
            }
        }
    }
}
