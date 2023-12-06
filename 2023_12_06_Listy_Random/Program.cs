using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*List<int> ints = new List<int>();

            ints.Add(1);
            ints.Add(10);
            ints.Add(5);

            Console.WriteLine($"Długość listy: {ints.Count}");

            ints.Add(5);
            ints.Add(1);
            Console.WriteLine($"Długość listy: {ints.Count}");

            foreach (int i in ints)
            {
                Console.WriteLine($"{i}");
            }

            ints.Remove(1);

            Console.WriteLine("--");
            foreach (int i in ints)
            {
                Console.WriteLine($"{i}");
            }
            */
            Random rand = new Random();
            List<int> ints = new List<int>();
            List<int> ints3_5 = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                ints.Add(rand.Next(1, 101));
            }
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Podzielne przez 3 lub 5");
            foreach (int i in ints3(ints3_5))
            {
                Console.WriteLine(i);
            }


            Console.ReadKey();
        }
        static List<int> ints3(List<int> ints3_5)
        {
            List<int> result = new List<int>();

            foreach (int i in ints3_5)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    ints3_5.Add(i);
                }
            }
            return ints3_5;
        }
    }
}
