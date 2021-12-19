using System;
/*
* Показать числа от -N до N
*/
namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberN = 0;
            Console.WriteLine( "Get number N" );
            NumberN = Convert.ToInt32(Console.ReadLine());;
            for (int i = -NumberN; i <= NumberN; i++)
            {
                 Console.Write( i + " ");
            }
        }
    }
}
