using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

// bir uçak bileti aldığımızı düşün bunun için ad soyad tc gideceğin yer bir tane de yas olsun içimden geldi.
// bir de galiba yaşadığın şehir lazım
// sınıf oluştururken önce sınıfı publicle tanımla.
//sonra nesnelerin değişkenlerini tanımla 
// sonra public içinde constructor ı tanımla ardından da this ile bunlar eşle
//sonra get metoduyla özellikleri çağır tek tek
//sonra ToString metoduyla ekrana yazdırma işlemini yap public string ToString
// en son main metodunun içine kullanıcı bilgilerini gir bitti bebek.

namespace oopOdev
{
    internal class Program
    {

        //sınıf oluşturma
        public class Kisi
        {
            //burada oluşturduğumuz sınıfın nesnelerinin değişkenlerini tanımladık tek tek 
            string ad;
            string soyad;
            int tc;
            string sehir;
            int yas;
            

            // constructor tanımlama bunu sınıf içinde tanımlaman lazım
            // yoksa hata alırsın sınıfın içine al. Az önce hata yapmıştın.
            public Kisi(string ad, string soyad, int tc, string sehir, int yas)
                
            {
                //this ile hepsini birbirine eşitledik.
                this.ad = ad;
                this.soyad = soyad;
                this.tc = tc;
                this.sehir = sehir;
                this.yas = yas;
                

            }

            // get ile özellikleri tek tek çağıracağız. Burada sınıfın içine yazılır.
            public string GetAd()
            {
                return ad;// returnle de döndürdük
            }

            public string GetSoyad()
            {
                return soyad;
            }

            public int GetTc()
            {
                return tc;
            }

            public string GetSehir()
            {
                return sehir;
            }

            public int GetYas()
            {
                return yas;
            }

            public string ToString()
            {
                return  ($"Kişinin Adı Soyadı: {this.GetAd()} {this.GetSoyad()} " +
                    $"\nKişinin Tc Kimlik Numarası: {this.GetTc()} \nKişinin Yaşadığı şehir: {this.GetSehir()} " +
                    $"\nKişinin Yaşı: {this.GetYas()}");
            }
        }

        class Musteri : Kisi // Müşteri sınıfı kişi sınıfını miras alarak yani kalıtım yaparak yeni sınıf oluşuyor.
        {
            string gidecegiSehir;
            int ucret;

            public Musteri(string ad, string soyad, int tc, string sehir, int yas, string gidecegiSehir, int ucret)
               : base(ad, soyad, tc, sehir, yas) // müsteri sınıfının constructor ını oluşturduk. Bunu oluşturmadığın için hata almıştım.
            {
                this.gidecegiSehir = gidecegiSehir;
                this.ucret = ucret;
            }
            public string GetGidecek()
            {
                return gidecegiSehir;
            }
            public int GetUcret()
            {
                return ucret;
            }
            public string ToString()
            {
                return ($"Müşteriniin Gideceği Şehir: {this.GetGidecek()} \nÜcret: {this.GetUcret()} TL");
            }
        }
        public static void Main(string[] args)
        {
            Kisi kisi = new Kisi("Esmanur", "Karataş", 2387, "Elazığ", 21);
            Console.WriteLine(kisi.ToString());

            Musteri musteri = new Musteri("Esmanur", "Karataş", 2387, "Elazığ", 21, "Malatya", 2000);
            Console.WriteLine(musteri.ToString());
        }


    }
}
