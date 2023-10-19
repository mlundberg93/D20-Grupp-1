using System.Collections;
using System.Runtime.CompilerServices;

namespace D20_Grupp_1
{
    internal class Program
    {

        static void Main(string[] args)
        {

            string userProfilePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string filePath = Path.Combine(userProfilePath, "Documents", "adresser.txt");

            if(!File.Exists(filePath))
            {
                File.Copy("adresser.txt", filePath);
            }
            Console.WriteLine("Hello and welcome to the Yellow Pages!");
            Console.WriteLine("If you need help, type help!");
            string command;
            do
            {


                Console.Write("Command: ");
                command = Console.ReadLine();
                if (command.ToLower() == "Help".ToLower())
                {
                    Console.WriteLine($"You can choose between these commandos: \n Load \n Add \n List \n Save \n Remove \n Exit");
                }
                else if (command.ToLower() == "Exit".ToLower())
                {

                }
                else if (command.ToLower() == "Load".ToLower())
                {
                    string[] text = File.ReadAllLines(filePath);
                    foreach (string s in text)
                    {
                        string[] splitLine = s.Split(',');
                        phoneList.Add(new Person(splitLine[0], splitLine[1], splitLine[2]));

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
                else if (command.ToLower() == "Add".ToLower())
                {
                    Console.WriteLine($"Make an addition to the Yellow Pages!\n" +
                        $"Enter your details here\nSeparated by a comma, e.g Marcus Lundberg,112,Lilla gatan 1: ");
                    string userInput = Console.ReadLine();
                    string[] stringParts = userInput.Split(',');
                    phoneList.Add(new Person(stringParts[0], stringParts[1], stringParts[2]));
                    Console.WriteLine($"Thank you for your contribution!");

                }
                else if (command.ToLower() == "Save".ToLower())
                {
                    
                    Console.WriteLine($"Saving data to the database!");
                    using (StreamWriter saveFile = new StreamWriter(filePath))
                    {
                        foreach (Person p in phoneList)
                        {
                            saveFile.WriteLine($"{p.name},{p.phone},{p.adress}");
                        }
                    }
                }
                else if (command.ToLower() == "remove")
                {
                    Console.WriteLine($"Please enter the name for the person you want to remove!");
                    string userInput = Console.ReadLine();
                    for (int i = 0; i < phoneList.Count; i++)
                    {
                        if (phoneList[i].name.ToLower() == userInput.ToLower())
                        {
                            phoneList.RemoveAt(i);
                            Console.WriteLine($"{userInput} has been removed!");
                            break;
                        }
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