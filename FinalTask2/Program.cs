namespace FinalTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("D:\\YandexDisk\\Синхронизация\\Skillfactory\\Module13\\FinalTask2\\Text1.txt");

            string noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());
            char[] delimiters = { ' ', '\r', '\n', };
            var words = noPunctuationText.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }

            var mostCommonWords = wordCount.OrderByDescending(c => c.Value);

            Console.WriteLine("Самые часто встречающиеся слова:");
            int displayedWords = 10;

            foreach (var pair in mostCommonWords)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value} раз");
                displayedWords--;
                if (displayedWords == 0) break;
            }
            Console.ReadLine();
            /*
                Самые часто встречающиеся слова:
                и: 5716 раз
                не: 3644 раз
                в: 3337 раз
                на: 2303 раз
                он: 1989 раз
                с: 1977 раз
                что: 1948 раз
                как: 1304 раз
                она: 1244 раз
                я: 1044 раз
             */
        }
    }
}