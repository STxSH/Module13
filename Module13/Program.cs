using System.Collections;
using System.Globalization;
using System.Text;

namespace Module13
{
    internal class Program
    {
        //task 13.5.4
        public static Stack<string> words = new Stack<string>();
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово и нажмите Enter, чтобы добавить его в стек.");
            Console.WriteLine();

            while (true)
            {
                var input = Console.ReadLine();


                switch (input)
                {
                    case "pop":
                        Console.WriteLine($"Удален элемент {words.Peek()}");
                        words.Pop(); 
                        break;
                    case "peek":
                        Console.WriteLine();
                        Console.WriteLine(words.Peek());
                        break;
                    default:
                        words.Push(input); 
                        break;
                }
                //words.Push(input); // Изменить здесь


                Console.WriteLine();
                Console.WriteLine("В стеке:");

                foreach (var word in words)
                {
                    Console.WriteLine(" " + word);
                }
            }

            
        }
    }

}