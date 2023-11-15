using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tablica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tabA = CreateArray("tabA");


            Console.ReadKey();

            
        }

        public static int[] CreateArray(string name)
        {
            Console.WriteLine($"podaj rozmiar tablicy {name}");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            return array;
        }

       
    }

}
