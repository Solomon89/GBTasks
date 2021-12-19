using System;
/*
* Выяснить является ли число чётным
*/
namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = 0;
            Console.WriteLine("Get number");
            Number = Convert.ToInt32(Console.ReadLine());
            if (Number % 2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd ");
            }
        }
    }
}
