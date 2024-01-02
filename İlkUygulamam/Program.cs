using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlkUygulamam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci sayıyı giriniz: ");
            double s1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz: ");
            double s2 = Convert.ToDouble(Console.ReadLine());

            double sonuc = s1 + s2;
            Console.Write("İşlemin sonucu: " + sonuc.ToString());          

            Console.ReadKey();


        }
    }
}
