using System.Collections;
using System.Collections.Concurrent;
using System.Globalization;
using System.Text;

namespace Module13
{
    internal class Program
    {
        //task 13.5.8

        public static ConcurrentQueue<string> words = new ConcurrentQueue<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово и нажмите Enter, чтобы добавить его в очередь.");
            Console.WriteLine();

            //  запустим обработку очереди в отдельном потоке
            StartQueueProcessing();

            while (true)
            {
                var input = Console.ReadLine();

                switch (input)
                {
                    case "peek":
                        words.TryPeek(out string peekResult);
                        Console.WriteLine(peekResult);
                        break;
                    default:
                        words.Enqueue(input);
                        break;
                }
                 // ИЗМЕНИТЬ ЗДЕСЬ
            }
        }

        // метод, который обрабатывает и разбирает нашу очередь в отдельном потоке
        // ( для выполнения задания изменять его не нужно )
        static void StartQueueProcessing()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;

                while (true)
                {
                    Thread.Sleep(5000);
                    if (words.TryDequeue(out var element))
                        Console.WriteLine("======>  " + element + " прошел очередь");
                }

            }).Start();
        }
    }

}