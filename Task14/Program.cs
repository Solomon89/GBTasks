using System;
/*
* Найти третью цифру числа или сообщить, что её нет
*/
namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = 0;
            Console.WriteLine("Get number ");
            Number = Convert.ToInt32(Console.ReadLine()); ;
            if (Number >= 100)
            {
                Number /= 100;
                int ThirdDigit = Number % 10;
                Console.WriteLine("Number of third Digit  is " + ThirdDigit);
            }
            else
            {
                Console.WriteLine("Number does't have third digit");
            }
        }
    }
}
