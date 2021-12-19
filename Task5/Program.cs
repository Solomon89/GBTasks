using System;
/*
* Написать программу вычисления значения функции y = f(a)
*/
namespace Task5
{
    class Program
    {
        static int functionBy(int a)
        {
            return a * a;
        }
        static void Main(string[] args)
        {
            int Number = 0;
            Console.WriteLine("Get numbers");
            Number = Convert.ToInt32(Console.ReadLine());
            int resultOfFunction = functionBy(Number);
            Console.WriteLine("Result Of function: " + resultOfFunction);
        }
    }
}
