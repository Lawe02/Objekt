using System;

namespace CRM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person kund;
            kund = new Person();

            kund.ålder = "23";
            kund.kön = "ickebinär";
            kund.utbildning = "gymnasial";

            Console.WriteLine($"Din kund är en {kund.ålder} årig { kund.kön} med en {kund.utbildning}. utbildning ");







        }
    }
    class Person
    {
        public string ålder { get; set; }
        public string kön { get; set; }
        public string utbildning { get; set; }

    }
}
    
