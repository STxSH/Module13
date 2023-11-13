using System.Collections;
using System.Text;

namespace Module13
{
    internal class Program
    {
        //task 13.4.4
        static void Main(string[] args)
        {

            var contacts = new Dictionary<string, Contact>();

            contacts.Add("Игорь", new Contact("Игорь", 79990000000, "igor@example.com"));
            contacts.Add("Андрей", new Contact("Андрей", 79990000001, "andrew@example.com"));

            foreach (var contact in contacts)
            {
                Console.WriteLine($"{contact.Key} : {contact.Value.PhoneNumber}");
            }
            Console.WriteLine();

            var anton = new Contact("Антон", 79990000002, "anton@example.com");
            contacts.Add(anton.Name, anton);

            foreach (var contact in contacts)
            {
                Console.WriteLine($"{contact.Key} : {contact.Value.PhoneNumber}");
            }

            Console.WriteLine();


            if (contacts.ContainsKey("Антон"))
            {
                contacts["Антон"].PhoneNumber = 333444;
            }

            foreach (var contact in contacts)
            {
                Console.WriteLine($"{contact.Key} : {contact.Value.PhoneNumber}");
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
        public long PhoneNumber { get; set; }
        public String Email { get; }
    }

}