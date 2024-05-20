using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace döviz_çevirme_uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tl, euro, dolar, euro_kur, dolar_kur;
            Console.WriteLine("TL Cinsinden para miktarı girin");
            tl= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Euro kurunu giriniz");
            euro_kur= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Dolar krunu giriniz");
            dolar_kur= Convert.ToDouble(Console.ReadLine());
            euro=tl/euro_kur;
            dolar = tl / dolar_kur;
            Console.WriteLine("{0} TL = {1:f2} Euro",tl,euro);
            Console.WriteLine("{0} TL = {1:f2} Dolar", tl, dolar);
            Console.ReadKey();
        }
    }
}
