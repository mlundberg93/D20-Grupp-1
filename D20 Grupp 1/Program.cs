using System.Runtime.CompilerServices;

namespace D20_Grupp_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej och välkommen till adresslistan.");
            Console.WriteLine("Skriv 'hjälp' för hjälp!");
            string command;
            do
            {
                Console.Write("Kommando: ");
                command = Console.ReadLine();
                if (command == "hjälp")
                {
                    Console.WriteLine($"Tyvärr ej implementerat!");
                }
                else if (command == "sluta")
                {

                }
                else
                {
                    Console.WriteLine($"Okänt kommando: {command}");
                }
            } while (command != "sluta");
            Console.WriteLine("Hej då!");
        }
        public class Person
        {
            public string name;
            public string phone;
            public string adress;

            public Person(string name, string phone, string adress)
            {
                this.name = name;
                this.phone = phone;
                this.adress = adress;
            }

            public void Print()
            {
                Console.WriteLine($"Name: {this.name}\n Phone: {this.phone}\n Adress: {this.adress}");
            }
            static List<string> phoneList = new List<string>();
        }
       
    }
}