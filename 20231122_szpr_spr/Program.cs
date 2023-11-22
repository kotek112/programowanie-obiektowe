using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*·!  Utwórz tablicę jednowymiarową o rozmiarze 10 i nazwij ją tablica (utwórz metodę tworzącą tablicę).
!       ·  W pętli for pobierz od użytkownika 10 liczb całkowitych i zapisz je w tablicy tablica. Jeśli użytkownik poda niepoprawną liczbę, program ma wyświetlić komunikat o błędzie i powtórzyć działanie.
!       ·  Oblicz i wyświetl na ekranie średnią arytmetyczną liczb z tablicy tablica. Średnia arytmetyczna jest równa sumie wszystkich liczb podzielonej przez ich liczbę (utwórz metodę)
!       ·  Wyświetl liczbę, która jest najmniejsza w tablicy (utwórz metodę)
       ·  W programie użyj bloków try-catch do obsługi wyjątków, takich jak niepoprawne dane wejściowe lub indeks poza zakresem tablicy.
!       ·  Program kończy się po wpisaniu quit*/
namespace szpr_kart_2023_11_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            bool correct = false;
            while (!correct) {
                try
                {
                    CreateArray();
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                    CreateArray();
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    CreateArray();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    CreateArray();
                }
                if (Console.ReadLine() == "quit")
                {
                    Environment.Exit(0);
                }
            }
           

        }
        public static void CreateArray()
        {
            double[] tablica = new double[10];
            for (int i = 0; i < tablica.Length; i++)
            {
                int pmi = i;
                Console.WriteLine($"Podaj wartośc dla indeksu {i}");
                string pm = Console.ReadLine();
                if (pm == "quit")
                {
                    Environment.Exit(0);
                }
                else
                tablica[i] = double.Parse(pm);
            }
            //double sred = Avarge(tablica);
            double sred2 = Avarge2(tablica);
            double minim = Minim(tablica);
            //Console.WriteLine($"Średnia arytmetyczna liczb w tablicy to {sred}");
            Console.WriteLine($"Średnia arytmetyczna liczb w tablicy to {sred2}");
            Console.WriteLine($"wartość minimalna w tablicy to {minim}");
        }
        public static double Minim(double[] tablica)
        {
            double minimum = tablica.Min();
            return minimum;
        }
        public static double Avarge2(double[] tablica)
        {
            double srednia2 = tablica.Average();
            return srednia2;
        }

        /*public static double Avarge(double[] tablica)
        {
            double srednia = 0;
            double pomoc = 0;
            for (int i = 0; i < tablica.Length; i++)
            {
                pomoc += tablica[i];
            }
            srednia = pomoc/tablica.Length;
            return srednia;
        }
        */

    }
}
