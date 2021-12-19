using System;
/*
* Показать четные числа от 1 до N
*/
namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberN = 0;
            Console.WriteLine("Get number N");
            NumberN = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= NumberN; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
