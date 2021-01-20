
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basitHesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı girin:");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Yapmak istediğiniz işlemi girin:");
            string islem = Console.ReadLine();
            Console.WriteLine("İkinci sayıyı girin:");
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            if (islem == "+")
                Console.WriteLine("SONUÇ:"+ (sayi1 + sayi2));
            else if (islem == "-")
                Console.WriteLine("SONUÇ:" + (sayi1-sayi2));
            else if (islem =="*")
                Console.WriteLine("SONUÇ:" + (sayi1 *sayi2));
            else if (islem == "/")
                Console.WriteLine("SONUÇ:"+ (sayi1/sayi2));
            else
                Console.WriteLine("Lütfen sadece işlem sembolü giriniz");

        }
    }
}
