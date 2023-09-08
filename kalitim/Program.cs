using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Dersler
{
    public void TumDersler()
    {
        Console.WriteLine("Lütfen bir alan seçiniz: \n 1: Sayısal \n 2: Sözel");
        int deger = Convert.ToInt32(Console.ReadLine());
     
        if (deger == 1)
        {
            Console.WriteLine("Sayisal Dersleri Seçtiniz.");
        }
        else if (deger == 2)
        {
            Console.WriteLine("Sözel Dersleri seçtiniz.");
        }
        else
        {
            Console.WriteLine("Yanlış değer girdiniz.");
        }
    }

    class Sayisal : Dersler
    {
        public void Say()
        {
            Console.WriteLine($"Lütfen bir ders seçiniz: \n Dersler: \n 1:Matematik \n 2:Fizik \n 3:Kimya \n 4:Biyoloji");
            int ders =Convert.ToInt32(Console.ReadLine());
            if (ders == 1)
            {
                Console.WriteLine("Matematik dersi ek ders olarak eklenmiştir.");
            } else if (ders == 2)
            {
                Console.WriteLine("Fizik dersi ek ders olarak eklenmiştir.");
            } else if (ders == 3)
            {
                Console.WriteLine("Kimya dersi ek ders olarak eklenmiştir.");
            } else if(ders == 4)
            {
                Console.WriteLine("Biyoloji dersi ek ders olarak eklenmiştir.");
            }
        }
    }
    class Sozel : Dersler
    {
        public void Soz() 
        {
            Console.WriteLine($"Lütfen bir ders seçiniz: \n Dersler: \n 1:Türkçe \n 2:Coğrafya \n 3:Edebiyat \n 4:Tarih");
            int ders = Convert.ToInt32(Console.ReadLine());
            if (ders == 1)
            {
                Console.WriteLine("Matematik dersi ek ders olarak eklenmiştir.");
            }
            else if (ders == 2)
            {
                Console.WriteLine("Fizik dersi ek ders olarak eklenmiştir.");
            }
            else if (ders == 3)
            {
                Console.WriteLine("Kimya dersi ek ders olarak eklenmiştir.");
            }
            else if (ders == 4)
            {
                Console.WriteLine("Biyoloji dersi ek ders olarak eklenmiştir.");
            }

        }
    }
    static void Main(string[] args)
    {
        Dersler dersler = new Dersler();
        dersler.TumDersler();

        Sayisal sayisal = new Sayisal();
        sayisal.Say();
        
        Sozel sozel = new Sozel();
        sozel.Soz();
  
    }
}


        

















//        class Araclar
//        {
//            public void hızlı()
//            {
//                Console.Write("Lütfen hızınızı giriniz: ");
//                int hız = Convert.ToInt32(Console.ReadLine());
//                if (hız > 200)
//                {
//                    Console.WriteLine("Hız Sınırını Aştınız!");
//                }
//                else
//                {
//                    Console.WriteLine("Hızınız Normal");
//                }
//            }
//        }

//            class Kara : Araclar
//            {
//                public void Marka()
//                {
//                    Console.Write("Aracınızın Markasını Giriniz: ");
//                    string marka = Console.ReadLine();
//                }
//            }

//            class Deniz : Araclar
//            {
//                public void Color()
//                {
//                    Console.Write("Aracınızın rengini Giriniz:");
//                    string color = Console.ReadLine();
//                }

//            }
//            class Hava : Araclar
//            {
//                public void model()
//                {
//                    Console.Write("Aracın modelini giriniz: ");
//                    int model = Convert.ToInt32(Console.ReadLine());
//                }

//            }

//            interface I1
//            {
//                void model1();
//            }

//            interface I2
//            {
//                void model2();
//            }

//            class MyClass : I1, I2
//            {
//                public void model1()
//                {
//                    Console.WriteLine("deneme");
//                }

//                public void model2()
//                {
//                    Console.WriteLine("hwejbdje");
//                }

//            }
//            static void Main(string[] args)
//            {
//                Araclar arac = new Araclar();
//                arac.hızlı();

//                Kara kara = new Kara();
//                kara.Marka();

//                Deniz deniz = new Deniz();
//                deniz.Color();

//                Hava hava = new Hava();
//                hava.model();


//            }
//        }
//    }

