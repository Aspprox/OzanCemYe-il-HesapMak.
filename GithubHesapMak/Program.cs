using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubHesapMak
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("1. Sayi: ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2. Sayi: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("İslem Seçiniz +, -, *, / ");
            string islem = Console.ReadLine();

            switch (islem)
            {
                case "+":
                    double sonuc = sayi1 + sayi2;
                    Console.WriteLine("Sonuç: " + sonuc);
                    break;
                case "-":
                    sonuc = sayi1 - sayi2;
                    Console.WriteLine("Sonuç: " + sonuc);
                    break;
                case "*":
                    sonuc = sayi1 * sayi2;
                    Console.WriteLine("Sonuç: " + sonuc);
                    break;
                case "/":
                    sonuc = sayi1 / sayi2;
                    Console.WriteLine("Sonuç: " + sonuc);
                    break;
                default:
                    Console.WriteLine("Hata");
                    break;
            }

            Console.ReadLine();

        }
    }
}

