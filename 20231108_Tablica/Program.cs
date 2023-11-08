using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study_project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Napisz program w C#, który wczytuje od użytkownika 5 liczb całkowitych i zapisuje je w tablicy. Następnie program prosi użytkownika o podanie indeksu tablicy 
                i wyświetla liczbę znajdującą się pod tym indeksem. Jeśli użytkownik wprowadzi indeks spoza zakresu tablicy, program powinien zgłosić wyjątek 
                ArgumentOutOfRangeException i wyświetlić odpowiedni komunikat. Jeśli użytkownik wprowadzi nieprawidłowe dane, program powinien zgłosić wyjątek FormatException 
                i poprosić o ponowne wprowadzenie danych. Program powinien działać w pętli, dopóki użytkownik nie wpisze q. Użyj instrukcji try-catch do obsługi wyjątków
                Jeśli liczba jest ujemna, program powinien zgłosić wyjątek ArgumentOutOfRangeException i wyświetlić odpowiedni komunikat. 
                Jeśli użytkownik wprowadzi nieprawidłowe dane, program powinien zgłosić wyjątek FormatException i poprosić o ponowne wprowadzenie liczby. 

             */

            int[] array = new int[5];
            bool isCorrect = false;
            do
            {
                Console.WriteLine("Wprowadź 5 liczb całkowitych: ");
                try
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.Write("Podaj liczbę: ");
                        array[i] = int.Parse(Console.ReadLine());

                    }
                    isCorrect = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nieprawidłowe dane. Wprowadź poprawną liczbę całkowitą.");


                }
                catch (OverflowException)
                {
                    Console.WriteLine($"Nieprawidłowe dane. Liczba poza zakresem <{int.MinValue} ; {int.MaxValue}>");
                }
            }
            while (!isCorrect);

            isCorrect = false;
            int index = 0;
            string input = "";

            Console.WriteLine("Dziękuje za wprowadzenie liczb.");

            do
            {
                try
                {
                    Console.Write("Wprowadź indeks tablicy: ");
                    input = Console.ReadLine();
                    if (input == "q")
                    {
                        Environment.Exit(0);
                    }
                    index = int.Parse(input);
                    if (index < 0)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    Console.Write("Twoja liczba to: {0}", array[index]);
                    isCorrect = true;
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine($"Podany indeks nie znajduje się w tablicy.");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine($"Twój indeks jest ujemny.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nieprawidłowe dane. Wprowadź poprawną liczbę całkowitą.");
                }
            }
            while (!isCorrect);
            Console.WriteLine("\nDziękuje za skorzystanie z programu.");

            /*
            foreach (int i in array)
            {
                Console.Write($"{i} ");
            }
            */

            Console.ReadKey();
        }
    }
}
