using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace degiskenler
{
    internal class Program
    {
        class KisiDetaylari // class oluşturduk.
        {       
                public void KisiYasi() { // metod oluşturduk. metotlar classların altına tanımlarız.
                // yerel değişkenler 
                int yas = 35; //yas değişkenine 35 atadık.
                yas += 20; // yaşı 20 arttırarak ekrana yazdıracağız.
                Console.WriteLine("Kişinin Yaşı " + yas);
}
                 static void Main(string[] args)
            { 
                // obje oluşturma referans veri tipi 
                KisiDetaylari obj = new KisiDetaylari(); // nesne oluşturduk.
                obj.KisiYasi(); //obje oluşturduktan sonra bu şekilde çağırmamız lazım.

            }
        }
    }
}
