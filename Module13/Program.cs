using System.Collections;
using System.Text;

namespace Module13
{
    internal class Program
    {
        //task 13.3.4
        static void Main(string[] args)
        {
            List<Contact> contacts = new List<Contact>
            {
                new Contact("Игорь", 79990000000, "igor@example.com"),
                new Contact("Андрей", 79990000001, "andrew@example.com"),
                new Contact("Игорь1", 79990000000, "igor@example.com"),
                new Contact("Андрей1", 79990000001, "andrew@example.com"),
                new Contact("Игорь2", 79990000000, "igor@example.com"),
                new Contact("Андрей3", 79990000001, "andrew@example.com"),
            };

            Contact Igor = new Contact("name", 38383838, "3983838");

            AddUnique(Igor, ref contacts);
        }

        public static void AddUnique(Contact contact, ref List<Contact> phoneBook)
        {
            if(!phoneBook.Contains(contact))
            {
                phoneBook.Add(contact);
            }

            phoneBook.Sort((x, y) => x.Name.CompareTo(y.Name));

            foreach (var contac in phoneBook)
            {
                Console.WriteLine(contac.Name);
            }

        }


    }

    public class Contact // модель класса
    {
        public Contact(string name, long phoneNumber, String email) // метод-конструктор
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public String Name { get; }
        public long PhoneNumber { get; }
        public String Email { get; }
    }
}