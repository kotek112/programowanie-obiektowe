using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            double a;
            Console.Write("podaj a");
            a = double.Parse(Console.ReadLine());
            */
            /*
            double a;
            Console.Write("podaj a: ");
            if (double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine(a);
            }
            */
            do {
                Console.WriteLine("chose 1 for triangle or 2 for rectangle");
                int w = int.Parse(Console.ReadLine());
                if (w == 1)
                {
                    bool IsCorrect = false;
                    double a;
                    do
                    {
                        Console.WriteLine("podaj a: ");

                        while (!double.TryParse(Console.ReadLine(), out a) || a <= 0)
                        {
                            Console.Write("podaj prawidlowo bok a: ");
                        }

                        Console.Write("podaj b: ");
                        double b;
                        while (!double.TryParse(Console.ReadLine(), out b) || b <= 0)
                        {
                            Console.Write("podaj prawidlowo bok b: ");
                        }

                        Console.Write("podaj c: ");
                        double c;
                        while (!double.TryParse(Console.ReadLine(), out c) || c <= 0)
                        {
                            Console.Write("podaj prawidlowo bok c: ");
                        }

                        if (IsTriangle(a, b, c))
                        {
                            IsCorrect = true;
                            double pole = AreaHeron(a, b, c);
                            Console.Write("To może być trojkat");
                            Console.OutputEncoding = System.Text.Encoding.Unicode;
                            Console.Write("Pole trojkata o bokach {0}, {1}, {2} wynosi: {3:F5}j \u00B2 ", a, b, c, pole);
                            Console.OutputEncoding = System.Text.Encoding.Default;


                        }
                        else
                        {
                            Console.Write("to nie może być trójkąt");
                            System.Threading.Thread.Sleep(1000);
                            Console.Clear();
                        }

                    }
                    while (!IsCorrect);
                }
                else if (w == 2)
                {
                    Console.WriteLine("podaj bok a: ");
                    double d = double.Parse(Console.ReadLine());
                    Console.WriteLine("podaj bok a: ");
                    double e = double.Parse(Console.ReadLine());
                    double f = d * e;
                    Console.WriteLine("pole prostokata to: {0}", f);
                }
                else
                {
                    Console.WriteLine("option unavalable");
                    System.Threading.Thread.Sleep(1000);

                }
            } while (!= 1 || 2);
            



          
            
            
            


            Console.ReadKey();
        }

        static bool IsTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        
        static double AreaHeron(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double pole = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return pole;
        }
        
    }
}
