using System;
using System.Xml.Linq;

namespace Module3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName = "Sunny";

            Console.WriteLine(myName);

            Console.WriteLine("\t Привет Мир");
            Console.WriteLine("\t Мне 27 лет");
            Console.WriteLine($"\t My name is \n {myName}");
            Console.WriteLine("\u0040");
            Console.WriteLine('\x23');

            Console.ReadKey();
        }
    }
}
