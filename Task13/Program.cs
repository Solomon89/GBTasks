using System;
/*
* Выяснить, кратно ли число заданному, если нет, вывести остаток.
*/
namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberA = 0;
            int NumberB = 0;

            Console.WriteLine("Number that multiple" );
            NumberA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number that is multiple " );
            NumberB = Convert.ToInt32(Console.ReadLine());

            int RemainderOfDivision = NumberA % NumberB;
            if (RemainderOfDivision == 0)
            {
                Console.WriteLine("Number is a multiple of the given one" );
            }
            else
            {
                Console.WriteLine("Number is not multiple of the given one and remainder of division - " + RemainderOfDivision );
            }
        }
    }
}
