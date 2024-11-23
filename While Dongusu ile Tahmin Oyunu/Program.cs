using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Dongusu_ile_Tahmin_Oyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int dogruSayi = random.Next(1, 101);
            int tahmin = 0;

            Console.WriteLine("1 ile 100 Arasında Bir Sayı Tahmin Edin:");

            while (tahmin != dogruSayi)
            {
                
                Console.Write("Tahmininiz: ");


                string giris = Console.ReadLine();
                if (int.TryParse(giris, out tahmin))
                {
                    if (tahmin < dogruSayi)
                    {
                        Console.WriteLine("Daha Büyük Bir Sayı Tahmin Edin.");
                    }
                    else if (tahmin > dogruSayi)
                    {
                        Console.WriteLine("Daha Küçük Bir Sayı Tahmin Edin.");
                    }
                    else
                    {
                        Console.WriteLine("Tebrikler! Doğru Tahmin Ettiniz!");
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen Geçerli Bir Sayı Girin.");
                }
            }

            Console.ReadKey();

        }
    }
}
