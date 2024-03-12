using System;
using System.Xml.Linq;

namespace Module3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = "Sunny";

            var age = checked((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine("Your name is {0} and age is {1} ", name, age);

            Console.Write("What is your favorite day of week? ");

            var day = (DayOfWeek)int.Parse(Console.ReadLine());
            Console.WriteLine("Your favorite day is {0}", day);
        }
    }
}

