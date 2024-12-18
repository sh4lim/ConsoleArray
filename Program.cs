using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArray
{
    internal class Program
    {
        static Dictionary<int, int> frequency = new Dictionary<int, int>();

        static Random rnd = new Random();

        static int[] ia= new int[100];

        static void Main(string[] args)
        {
            for (int i = 1; i != ia.Length; i++)
            {
                ia[i] = rnd.Next(0, 5000);
                Console.WriteLine(ia[i]);
            }

            Console.WriteLine();

            for (int i = 1; i != ia.Length; i++)
            {
                Array.Sort(ia);

                Console.WriteLine(ia[i]);
            }


            foreach (int number in ia)
            {
                if (frequency.ContainsKey(number))
                {
                    frequency[number]++;
                }
                else
                {
                    frequency[number] = 1;
                }
            }


            foreach (var kvp in frequency)
            {
                Console.WriteLine($"Число {kvp.Key} встречается {kvp.Value} раз");
            }


            Console.ReadKey();
        }
    }
}
