using System;
/*
* Найти максимальное из трех чисел
*/
namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int FirstNumber = 0;
            int SecondNumber = 0;
            int ThirdNumber = 0;
            Console.WriteLine("Get first numbers");
            FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Get second numbers");
            SecondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Get third numbers");
            ThirdNumber = Convert.ToInt32(Console.ReadLine());
            if (FirstNumber > SecondNumber && FirstNumber > ThirdNumber)
            {
                Console.WriteLine("Greater number is first: " + FirstNumber);
            }
            else if (SecondNumber > ThirdNumber)
            {
                Console.WriteLine("Greater number  is second: " + SecondNumber);
            }
            else
            {
                Console.WriteLine("Greater number  is third: " + ThirdNumber);
            }
        }
    }
}
