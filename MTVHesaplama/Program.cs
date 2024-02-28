using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSinavi
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Lütfen Motor Hacminizi Metre Kare Cinsinden Giriniz: ");
            int motorhacmi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen Araç Yaşınızı Giriniz: ");
            int aracyasi = Convert.ToInt32(Console.ReadLine());

            if (motorhacmi <= 1299)
            {
                if (aracyasi <= 3)
                {
                    Console.Write(" MTV Ödemeniz 960 Tl ");
                }

                if (aracyasi <= 6 && aracyasi >= 4)
                {
                    Console.WriteLine("MTV Ödemeniz 670 Tl ");
                }

                if (aracyasi <= 11 && aracyasi >= 7)
                {
                    Console.WriteLine("MTV Ödemeniz 378 Tl ");
                }
            }

            if (motorhacmi <= 1599 && motorhacmi >= 1300)
            {
                if (aracyasi <= 3)
                {
                    Console.Write("MTV Ödemeniz 1536 Tl ");
                }

                if (aracyasi <= 6 && aracyasi >= 4)
                {
                    Console.WriteLine("MTV Ödemeniz 1152 Tl");
                }

                if (aracyasi <= 11 && aracyasi >= 7)
                {
                    Console.WriteLine("MTV Ödemeniz 670 Tl ");
                }
            }

            if (motorhacmi >= 1600)
            {
                if (aracyasi <= 3)
                {
                    Console.Write("MTV Ödemeniz 2704 Tl ");
                }

                if (aracyasi <= 6 && aracyasi >= 4)
                {
                    Console.WriteLine("MTV Ödemeniz 2118 Tl ");
                }

                if (aracyasi <= 11 && aracyasi >= 7)
                {
                    Console.WriteLine("MTV Ödemeniz 1248 Tl ");
                }
            }

            Console.ReadKey();
        }
    }
}
