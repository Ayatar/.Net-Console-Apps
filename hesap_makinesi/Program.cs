using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesap_makinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char cikis;
            
            do
            {
                Console.Clear();
                int sonuc = 0;
     
                Console.Write("1. sayıyı girin : ");
                int sayi1 = Convert.ToInt16(Console.ReadLine());
                Console.Write("2. sayıyı girin : ");
                int sayi2 = Convert.ToInt16(Console.ReadLine());
                

                Console.WriteLine("Toplama İşlemi İçin +");
                Console.WriteLine("Çıkarma İşlemi İçin -");
                Console.WriteLine("Çarpma İşlemi İçin *");
                Console.WriteLine("Bölme İşlemi İçin /");
                Console.WriteLine("Yapmak İstediğiniz işlemi Seçin : ");


                char secim = Convert.ToChar(Console.ReadLine());
                
                switch (secim)
                {
                    case '+':
                        sonuc = sayi1 + sayi2;
                        Console.WriteLine("Toplama işlemini sonucu : {0}", sonuc);
                        break;
                    case '-':
                        sonuc = sayi1 - sayi2;
                        Console.WriteLine("Çıkarma işleminin sonucu : {0}", sonuc);
                        break;
                    case '*':
                        sonuc = sayi1 * sayi2;
                        Console.WriteLine("Çarpma işleminin sonucu : {0}", sonuc);
                        break;
                    case '/':
                        sonuc = sayi1 / sayi2;
                        Console.WriteLine("Bölme işleminin sonucu : {0}", sonuc);
                        break;
                    default:
                        Console.WriteLine("Hatalı Seçim Yaptınız");
                        break;
                }
                Console.WriteLine("Başka işlem yapacak mısınız?(e/h)");
                cikis = Convert.ToChar(Console.ReadLine());
            } while (cikis != 'h');

        }
    }
}

