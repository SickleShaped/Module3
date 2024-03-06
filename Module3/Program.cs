using System;
using System.Xml.Linq;

namespace Module3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName = "Sunny";
            byte myAge = 21;
            bool haveAPet = true;
            float shoeSize = (float)42.3;

            Console.WriteLine("My name is "+ myName);
            Console.WriteLine("My age is " + myAge);
            Console.WriteLine("Do i have a pet?" + haveAPet);
            Console.WriteLine("My shoe size is " + shoeSize);


            Console.ReadKey();
        }
    }
}
