using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsluSayiHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int taban, üssayi,  hesaplama = 1;

            Console.WriteLine("Üslü Sayı Hesaplayan Programa Hoşgeldiniz.\n ");

            
            Console.Write("Taban sayısını Giriniz Lütfen : ");
            taban = Convert.ToInt32(Console.ReadLine());
           
            

            Console.Write("Kuvvet Sayısını Giriniz Lütfen :  ");
            üssayi = Convert.ToInt32(Console.ReadLine());
            
            

            for (int i = 1; i <= üssayi; i++)
              {

                  hesaplama = hesaplama * taban;

                }
            

                Console.WriteLine("{0} üssü {1} olan sayının sonucu = {2} ", taban, üssayi, hesaplama);
                Console.ReadKey();
            
        }
    }
}
