using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ContactsAppSimulator
{
    public class Phonebook
    {
        public List<Contact> Contacts {get; set;} = new List<Contact>();
        public void DisplayContact(List<Contact> contacts)
        {
            foreach (Contact contact in contacts)
            {
                Console.WriteLine($"Contact: {contact.Name}, {contact.Number}");
            }
        }
        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }
        public void DisplayContactByNumber(string number)
        {
            var contacts = Contacts.FindAll(c => c.Number.Contains(number)).ToList();
            if (contacts == null)
            {
                Console.WriteLine($"Contact {number} does not exist");
            }
            else
            {
                DisplayContact(contacts);
            }
        }
        public void DisplayAll()
        {
            foreach (Contact contact in Contacts)
            {
                Console.WriteLine($"Name: {contact.Name} Number: {contact.Number}");
            }
        }

        public void DisplayContactsByName(string name)
        {
            var contacts = Contacts.FindAll(c => c.Name.Contains(name)).ToList();
            if (contacts == null)
            {
                Console.WriteLine($"Contact {name} does not exist");
            }
            else
            {
                DisplayContact(contacts);
            }
        }
    }
}
