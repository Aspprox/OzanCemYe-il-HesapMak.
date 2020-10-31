using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. Sayıyı Giriniz:");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İşlem Belirtiniz: +, -, *, / ");
            string islem = Console.ReadLine();
            Console.Write("2. Sayıyı Giriniz:");
            double sayi2 = Convert.ToDouble(Console.ReadLine());


            if (islem == "+")
            {
                double sonuc = sayi1 + sayi2;
                Console.WriteLine("Sonuç: " + sonuc);
            }
            if (islem == "-")
            {
                double sonuc = sayi1 - sayi2;
                Console.WriteLine("Sonuç: " + sonuc);
            }
            if (islem == "*")
            {
                double sonuc = sayi1 * sayi2;
                Console.WriteLine("Sonuç: " + sonuc);
            }
            if (islem == "/")
            {
                if (sayi2 == 0)
                {
                    Console.WriteLine("Payda 0 olamaz.Lütfen başka bir işlem deneyin.");
                }
                else
                {
                    double sonuc = sayi1 / sayi2;
                    Console.WriteLine("Sonuç: " + sonuc);
                }
                
            }
            Console.ReadLine();
        }
             
    }
}

//if (sayi2 == 0)
//{
//    Console.WriteLine("Payda 0 olamaz.Lütfen başka bir işlem deneyin");
//}
//else
//{
//    double sonuc = sayi1 / sayi2;
//    Console.WriteLine("Sonuç: " + sonuc);