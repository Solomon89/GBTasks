using System;
/*
* По заданному номеру дня недели вывести его название
*/
namespace Tesk3
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberOfWeek = 0;
            Console.WriteLine( "Insert number of week");
            cin >> NumberOfWeek;
            switch (NumberOfWeek % 7 + 1)
            {
                case 1:
                    {
                        Console.WriteLine( "Monday");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine( "Tuesday");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine( "Wednesday");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine( "Thursday");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine( "Friday");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine( "Saturday");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine( "Sunday");
                        break;
                    }

            }
        }
    }
}
