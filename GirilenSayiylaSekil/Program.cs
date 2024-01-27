using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirilenSayiylaSekil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b = 0;

            Console.Write("Sayıyı Giriniz: ");
           int n = Convert.ToInt32 (Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("A");
            }
            Console.Write ("\n");

            for (int i = n;  i > 0; i = i - 2) {

                for (int k = 0; k < b ; k++)
                {
                    Console.Write(" ");
                }
                    Console.Write("A");


                for (int x = 0; x < i-2; x++)
                {
                    Console.Write(" ");
                }
                    Console.Write("A");
                b++;
                    Console.Write("\n");
            }
            
            Console.Read();
        }

    }
}
