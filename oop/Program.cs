//using system;
//using system.collections.generic;
//using system.linq;
//using system.text;
//using system.threading.tasks;

//namespace oop
//{
//    internal class Program
//   {
//        public class Ogrenci
//        {
//            string ad;
//            string soyad;
//            string bolum;
//            int yas;
//            int mezuniyetYili;

//            public Ogrenci(String ad, String soyad, string bolum, int yas, int mezuniyetYili)
//            {
//                this.ad = ad;
//                this.soyad = soyad;
//                this.bolum = bolum;
//                this.yas = yas;
//                this.mezuniyetYili = mezuniyetYili;
//            }

//            public string GetAd()
//            {
//                return ad;
//            }
//            public string GetSoyad()
//            {
//                return soyad;
//            }

//            public string GetBolum()
//            {
//                return bolum;
//            }
//            public int GetYas()
//            {
//                return yas;
//            }

//            public int GetMezuniyetYili()
//            {
//                return mezuniyetYili;
//            }

//            public string ToString()
//            {
//                return ("Merhaba adim " + this.GetAd() + "soyadim  " + this.GetSoyad() + " yasim " + this.GetYas() + "bolumum " + this.GetBolum() + "" +
//                    "  mezuniyet yilim " + this.GetMezuniyetYili() + "dir");

//            }



using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace oop
    {
        internal class Program
        {

            string ad;
            string soyad;
            int yas;
            string bolum;
            int mezuniyet;

            public Program(string ad, string soyad, int yas, string bolum, int mezuniyet)
            {
                this.ad = ad;
                this.soyad = soyad;
                this.yas = yas;
                this.bolum = bolum;
                this.mezuniyet = mezuniyet;

            }
            public string GetAd()
            {
                return ad;
            }
            public string GetSoyad()
            {
                return soyad;
            }
            public int GetYas()
            {
                return yas;
            }
            public string GetBolum()
            {
                return bolum;
            }
            public int GetMezuniyet()
            {
                return mezuniyet;
            }

            public string ToString()
            {
                return ("Merhaba adim " + this.GetAd() + "soyadim  " + this.GetSoyad() + " yasim " + this.GetYas() + "bolumum " + this.GetBolum() + "" +
                    "  mezuniyet yilim " + this.GetMezuniyet() + "dir");

            }
            public static void Main(String[] args)
            {
                Program ogrenci = new Program("Esmanur", "Karataş", 21, "Bilgisayar", 2022);
                Console.WriteLine(ogrenci.ToString());
            }
        }
    }






