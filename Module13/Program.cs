using System.Collections;

namespace Module13
{
    internal class Program
    {
        //task 13.2.5
        static void Main(string[] args)
        {
            var months = new[]
                {
                "Jan", "Feb", "Mar", "Apr", "May" , "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
                };

            var numbers = new[]
                {
                 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12
                };

            var arList = new ArrayList();
            
            for (int i = 0; i < months.Length; i++)
            {
                arList.Add(months[i]);
                arList.Add(numbers[i]);
            }
            foreach (var i in arList)
            {
                Console.WriteLine(i);
            }
        }
    }
}