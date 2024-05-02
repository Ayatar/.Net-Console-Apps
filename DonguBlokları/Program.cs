using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonguBlokları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen bir sayı girinz: ");
            int s = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < s; i++)
            //{
            //    if (i%5==0 && i%2!=0)
            //    {
            //        Console.WriteLine(i.ToString());
            //    }

            //}
            int x = 0;
            while (x <= s)
            {
                x++;
                if (x % 5 == 0 && x % 2 != 0 )
                {
                    Console.WriteLine(x.ToString());
                }

            }
            Console.ReadKey();
        }
    }
}
