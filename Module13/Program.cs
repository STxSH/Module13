using System.Collections;
using System.Text;

namespace Module13
{
    internal class Program
    {
        //task 13.2.6
        static void Main(string[] args)
        {
            
        }

        public static ArrayList method (ArrayList arrayList)
        {
            var result = new ArrayList ();

            int SumNumbers = 0;
            StringBuilder sb = new StringBuilder ();

            foreach(var a in arrayList)
            {
                if (a is int)
                {
                    SumNumbers += (int)a;
                }
                else if (a is string)
                {
                    sb.Append (a + " ");
                }
            }

            result.Add(SumNumbers);
            result.Add (sb.ToString ());

            return result;
        }
    }
}