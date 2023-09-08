using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kapsulleme
{
    internal class Program
    {
        public class Kapsulleme
        {


            private String Hesapİsmi;
            private int Sifre;

            public string KisiBilgisi
            {
                get { return Hesapİsmi; }
                set { Hesapİsmi = value; }
            }
            public int KisiSifre
            {
                get { return Sifre; }
                set { Sifre = value; }
            }
        }

        class Banka
        {

            //Driver Class

            static public void Main()
            {
                Kapsulleme obj = new Kapsulleme();
                obj.KisiBilgisi = "esma";
                obj.KisiSifre = 526;

                Console.WriteLine("Kullanıcı İsmi: " + obj.KisiBilgisi);
                Console.WriteLine("Kullanıcı Sifre: "+obj.KisiSifre);
            }
        }
    }
}// kapsülleme verileri gizliyor soyutlama ayrıntıları gizliyor.

