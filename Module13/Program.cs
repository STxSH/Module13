namespace Module13
{
    internal class Program
    {
        //task 13.1.6
        static void Main(string[] args)
        {
            string path = "D:\\YandexAnton\\main\\YandexDisk\\Синхронизация\\Skillfactory\\Module13\\cdev_Text.txt";

            
            if (File.Exists(path))
            {
                string fileText = File.ReadAllText(path);

                char[] separators = new char[] { ' ', '\r', '\n' };

                string[] words = fileText.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                Console.WriteLine(words.Length);
            }

        }
    }
}