namespace Module13
{
    internal class Program
    {
        //task 13.1.4
        static void Main(string[] args)
        {
            int[] ints = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = int.Parse(Console.ReadLine());
            }

            bool isSort = false;

            for (int i = 0; i < ints.Length-1;i++)
            {
                if (ints[i+1] > ints[i])
                {
                    isSort = true;
                }
                else
                {
                    isSort = false;
                    break;
                }
            }
            Console.WriteLine(isSort);

        }
    }
}