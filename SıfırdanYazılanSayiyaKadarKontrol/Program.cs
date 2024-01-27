using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SıfırdanYazılanSayiyaKadarKontrol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Lütfen Sayiyi Giriniz: ");
            double s1  = Convert.ToDouble(Console.ReadLine());
            try
            {
                for (int i = 0; i < s1; i++)
                {
                    if (i % 5 == 0 || i % 3 != 0)
                    {
                        Console.Write(i);
                    }
                }
                Console.ReadKey();
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
