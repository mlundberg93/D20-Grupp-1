﻿namespace D20_Grupp_1
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
        }
    }
}