using System.Diagnostics;

namespace FinalTask1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string text = File.ReadAllText("D:\\YandexDisk\\Синхронизация\\Skillfactory\\Module13\\FinalTask1\\Text1.txt");

            char[] delimiters = { ' ', '\r', '\n', ',', '.', ';', ':', '!', '?' };
            var words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            List<string> wordList = new List<string>();
            LinkedList<string> wordLinkedList = new LinkedList<string>();

            var watchOne = Stopwatch.StartNew();
            foreach (var word in words)
            {
                wordList.Add(word);
            }
            watchOne.Stop();
            Console.WriteLine($"Вставка в List: {watchOne.Elapsed.TotalMilliseconds} мс");
            //Вставка в List: 2,6105 мс

            var watchTwo = Stopwatch.StartNew();
            foreach (var word in words)
            {
                wordLinkedList.AddLast(word);
            }
            watchTwo.Stop();
            Console.WriteLine($"Вставка в LinkedList: {watchTwo.Elapsed.TotalMilliseconds} мс");
            //Вставка в LinkedList: 18,5717 мс


        }
    }
}