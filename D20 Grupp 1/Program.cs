using System.Collections;
using System.Runtime.CompilerServices;

namespace D20_Grupp_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to the Yellow Pages!");
            Console.WriteLine("If you need help, type help!");
            string command;
            do
            {
                Console.Write("Command: ");
                command = Console.ReadLine();
                if (command.ToLower() == "Help".ToLower())
                {
                    Console.WriteLine($"You can choose between these commandos: \n Load \n Add \n Save \n Delete \n Exit");
                }
                else if (command.ToLower() == "Exit".ToLower())
                {

                }
                else if (command.ToLower() == "Load".ToLower())
                {
                    string[] text = File.ReadAllLines("adresser.txt");
                    foreach (string s in text)
                    {
                        string[] splitLine = s.Split(',');
                        phoneList.Add(new Person(splitLine[0], splitLine[1], splitLine[2]));
                        //Console.WriteLine($"Name: {splitLine[0]} \nPhone: {splitLine[1]} \nAdress: {splitLine[2]}\n");
                    }
                    
                }
                else if (command.ToLower() == "List".ToLower())
                {
                    Console.WriteLine($"The yellow pages so far contains: \n");
                    foreach (Person p in phoneList)
                    {
                        p.Print();
                    }
                }
                else
                {
                    Console.WriteLine($"Unkown command: {command}");
                }
            } while (command.ToLower() != "Exit".ToLower());
            Console.WriteLine("Goodbye!");
        }
        static List<Person> phoneList = new List<Person>();
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
                Console.WriteLine($"Name: {this.name}\n Phone: {this.phone}\n Adress: {this.adress}\n");
            }

        }


    }
}