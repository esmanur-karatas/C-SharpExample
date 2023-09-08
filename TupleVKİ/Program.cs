using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleVKİ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kilonuzu Giriniz: ");
            double kilo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Boyunuzu Giriniz: ");
            double boy = Convert.ToInt32(Console.ReadLine());

            Tuple<double, double> degerler = Tuple.Create(kilo, boy);
            double vki= degerler.Item1 / (degerler.Item2 * degerler.Item2);
            Console.WriteLine($"Vücut Kitle İndeksiniz: {vki}");


        }
    }
}
