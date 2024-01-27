using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaktoriyelHesabi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faktöriyel Hesaplayan Algoritma Programına Hoş Geldiniz\n");

            Console.Write("Lütfen Faktöriyelini Hesaplama İstediğiniz Sayıyı Giriniz: ");
            double s1 = Convert.ToDouble(Console.ReadLine());

            double hesaplama = 1;

            for (int i = 1; i <= s1; i++)
            {
                hesaplama *= i;
            }
            Console.Write("Girilen sayının faktöriyeli: " + hesaplama);

            Console.ReadKey();
        }
    }
}
