using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                ConsoleKeyInfo cki;

            baslangıc:
                double s, kar, sonuc;
                Console.Write("Lütfen Alış Fiyatını Giriniz: ");
                s = Convert.ToDouble(Console.ReadLine());

                Console.Write("Kar oranını giriniz: ");
                kar = Convert.ToDouble(Console.ReadLine());

                sonuc = s * kar / 100 + s;

                Console.WriteLine("Alış fiyatı {0}, karı {1} olan ürünün satış fiyatı {2} ", s, kar, sonuc);

                Console.Write("Tekrar hesap yapak istiyor musunuz (y/n)");
                cki = Console.ReadKey();
                Console.WriteLine();

                if (cki.Key == ConsoleKey.Y)
                {
                    Console.WriteLine();
                    goto baslangıc;

                }
                else if (cki.Key == ConsoleKey.N)
                {

                    Environment.Exit(1);


                }
            }
            catch (Exception ex)
            {

                Console.Write(ex.Message);

            }
        }
    }
}
