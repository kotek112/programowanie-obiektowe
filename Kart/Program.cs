using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kartkówka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisz program w C#, który wczytuje promień koła od użytkownika i oblicza jego obwód (funkcja statyczna) i pole (funkcja statyczna) według wzorów: obwód = 2πr, pole = πr^2. Jeśli użytkownik wprowadzi liczbę mniejszą lub równą zero, program powinien wyświetlić komunikat o błędnych danych. Jeśli użytkownik wprowadzi nieprawidłowe dane, program powinien wyświetlić komunikat o nieprawidłowym formacie i poprosić o ponowne wprowadzenie danych. Program powinien działać w pętli, dopóki użytkownik nie wpisze q lub użytkownik poda prawidłowe dane i będzie możliwe obliczenie pola i obwodu. Użyj instrukcji try-catch do obsługi wyjątków. Tylko wynik pola i obwód wyświetl w kolorze zielonym.
            bool check = false;
            do
            {
                try
                {
                    Console.WriteLine("Podaj promień wariacie: ");
                    double R;
                    while (!double.TryParse(Console.ReadLine(), out R)) ;
                    {
                        if (R <= 0) throw new Exception("Promień nie może być mniejszy/równy 0");
                        Console.WriteLine("\nPodaj promień wariacie: ");
                    }

                    Console.OutputEncoding = Encoding.Unicode;
                    Console.WriteLine("Pole wynosi: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{CirclePole(R)}\u00B2");
                    Console.ResetColor();
                    Console.WriteLine("Obwód wynosi: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(CircleObwód(R));
                    Console.ResetColor();
                    Console.OutputEncoding = Encoding.Default;
                    check = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Błąd: {ex.Message}");
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine($"Błąd: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Błąd: {ex.Message}");
                }
            }
            while (!check);
            Console.ReadKey();
        }



        static double CirclePole(double x)
        {
            return x * x * Math.PI;
        }

        static double CircleObwód(double x)
        {
            return 2 * x * Math.PI;
        }
    }
}
