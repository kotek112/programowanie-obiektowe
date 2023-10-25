using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static string ColorChangeGood(string comment)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            return comment;
        }
        static string ColorChangeBad(string comment)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            return comment;
        }
        static void Main(string[] args)
        {
            bool correct = false;

            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("podaj 2 liczby: ");
                try
                {
                    Console.Write("\npodaj x: ");
                    int x = int.Parse(Console.ReadLine());
                    Console.Write("podaj y: ");
                    int y = int.Parse(Console.ReadLine());
                    int z = x / y;
                    Console.Write($"iloraz liczb ");
                    Console.Write(ColorChangeGood($"{x} / {y} = {x/y} "));
                    correct = true;

                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ColorChangeBad($"\nliczba zbyt duza: <{int.MinValue}; {int.MaxValue}> szczegółowiej: {ex.Message}"));
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ColorChangeBad($"\nnie dziel przez zero dziadu szczegółowiej: {ex.Message}"));
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ColorChangeBad($"\npodaj prawidłowe dane. Szczegółowiej: {ex.Message}"));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ColorChangeBad($"\nbłąd: {ex.Message}"));
                }
                finally
                {
                    Console.WriteLine("\nDziękujemy za wybranie PLL LOT \n");
                }
            }
            while (!correct);
            
            


            Console.ReadKey();
        }
    }
}
