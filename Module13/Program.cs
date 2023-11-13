using System.Collections;
using System.Text;

namespace Module13
{
    internal class Program
    {
        //task 13.3.10
        static void Main(string[] args)
        {
            string text = "Подсчитайте, сколько уникальных символов в этом предложении, используя HashSet<T>, учитывая знаки препинания, но не учитывая пробелы в начале и в конце предложения.";

            var set  = new HashSet<char>();

            foreach (char c in text)
            {
                    set.Add(c);
              
            }

            Console.WriteLine(set.Count);
        }



    }

}