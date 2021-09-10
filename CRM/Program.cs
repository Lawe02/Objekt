using System;
using System.Collections.Generic;

namespace CRM
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> myPerson = new List<Person>();
            while (true)
            {
                Console.WriteLine("1-Skapa ny kund, 2-Visa antal kunder, 3-Visa lista över alla kunder, 4-Avsluta");
                string val = Console.ReadLine();

                if (val == "1")
                {
                    Console.WriteLine("Ge ut kundens ålder");
                    string kundÅlder = Console.ReadLine();
                    Console.WriteLine("Ge ut kundens kön");
                    string kundKön = Console.ReadLine();
                    Console.WriteLine("Har kunden körkort?");
                    string kundKort = Console.ReadLine();

                    myPerson.Add(new Person() { ålder = kundÅlder, kön = kundKön, körkort = kundKort });

}

                if (val == "2")
                {
                    Console.Clear();
                    Console.WriteLine($" Det finns {myPerson.Count} personer i systemet .");

                }
                if (val == "3")  
                {
                    Console.Clear();

                     
                    foreach (Person c in myPerson)
                    {
                        Console.WriteLine($"Ålder: {c.ålder}\n" +
                                          $"Kön: {c.kön}\n" +
                                          $"Körkort: {c.körkort}\n");
                    }

                    if (val == "4")  
                    {
                        break;
                         
                    }
                    if (val != "1" && val != "2" && val != "3" && val != "4")
                    {
                        Console.Clear();
                        Console.WriteLine("Du måste ange val 1, 2, 3, 4 för att få ut någonting.");
                    }

                     
                    Console.ReadLine();

                }
            } 

                
            

            



        }
    }
    class Person
    {
        public string ålder { get; set; }
        public string kön { get; set; }
        public string körkort { get; set; }

    }
}
    
