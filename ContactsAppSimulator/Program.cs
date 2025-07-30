using System.Reflection.Metadata;

namespace ContactsAppSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Phonebook = new Phonebook();

            Console.WriteLine("Welcome to the PhoneBookSimulation App");
            Console.WriteLine("Choose what do you want to do: ");
            Console.WriteLine("1 - Add Contact");
            Console.WriteLine("2 - Display all contacts");
            Console.WriteLine("3 - Search for contact by number");
            Console.WriteLine("4 -  Seatch for contact by name");
            Console.WriteLine("x - Closes App");
            Console.WriteLine();
            var userInput = Console.ReadLine();
            Console.WriteLine();
            while (true)
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Insert contact name:");
                        var name = Console.ReadLine();
                        if(name.Equals(""))
                        {
                            Console.WriteLine("Invalid name! Try again.");
                            break;
                        }
                        Console.WriteLine("Insert contac number:");
                        var number = Console.ReadLine();

                        var newContact = new Contact(name, number);

                        Phonebook.AddContact(newContact);
                        break;
                    case "2":
                        Phonebook.DisplayAll();
                        break;
                    case "3":
                        Console.WriteLine("Search for a number: ");
                        var searchNumber = Console.ReadLine();
                        if (searchNumber.Equals(""))
                        {
                            Console.WriteLine("Please enter value!");
                            break;
                        }
                        Phonebook.DisplayContactByNumber(searchNumber);
                        break;
                    case "4":
                        Console.WriteLine("Search for a name: ");
                        var searchName = Console.ReadLine();
                        if (searchName.Equals(""))
                        {
                            Console.WriteLine("Please enter value!");
                            break;
                        }
                        Phonebook.DisplayContactsByName(searchName);
                        break;
                    case "x":
                        return;
                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Choose what do you want to do: ");
                Console.WriteLine("1 - Add Contact");
                Console.WriteLine("2 - Display all contacts");
                Console.WriteLine("3 - Search for contact by number");
                Console.WriteLine("4 -  Seatch for contact by name");
                Console.WriteLine("x - Closes App");
                Console.WriteLine();
                userInput = Console.ReadLine();
            }
            
        }
    }
}
