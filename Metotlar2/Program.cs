//HESAP MAKİNESİNİN DEĞER DÖNDÜREN METOTLA YAPIMI
Console.WriteLine("1. Sayıyı Giriniz:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2. Sayıyı Giriniz:");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz: \n1:Toplama \n2:Çarpma \n3:Bölme \n4:Çıkarma");
int islem = Convert.ToInt32(Console.ReadLine());

switch (islem)
{
    case 1:
        ToplaSwitch(number1, number2);
        break;
    case 2:
        CarpSwitch(number1, number2);
        break;
    case 3:
        {
            if (number2 == 0)
            {
                Console.WriteLine("Payda sıfır olamaz.");
            }
            else
            {
                Console.WriteLine(Bolme(number1,number2));
            }
            break;
        }
    case 4:
        Cikar(number1, number2);
        break;
    default:
        Console.WriteLine("Yanlış değer girdiniz.");
        break;

}

void ToplaSwitch(int c, int d)
{
    Console.WriteLine(c + d);
}
void CarpSwitch(int c, int d)
{
    Console.WriteLine(c * d);
}

int Bolme(int c, int d)
{
    return c / d;
}

int Cikar(int c, int d)
{
    return c - d;
}

//METOTLAR: Kodumuzu daha temiz yazmak için metotlar kullanılır. metotlar bir çokm yerde kullanacaksak eğer metotları kullanmamız rahat olur.
//DEĞER DÖNDÜRMEYEN METOTLAR: Bunlarda void kullanırız yani herhangi bir değer vermeden lap diye ekrana bastırınca kullanırız.
string ad = "Furkan";
string soyad = "Oğuz";
İsimYazdir(ad, soyad);// metotlar böyle çağrılabilir.
İsimYazdir(soyad: "Doğan", ad: "Ahmet");// metotlar bu şekilde de kullanılabiliyor.
İsimYazdir(soyad: soyad, ad: ad);// metotları bu şekilde de daha önceden tanımladığımız isim  ve soyisimi çağırabiliriz.
İsimYazdir("Esmanur", "KARATAŞ");// Bu şekilde de değr veri çağırabiliriz
//Console.WriteLine($"Ad: {ad}, Soyad: {soyad}"); //mesela yukarıdaki metot sayesinde console da tek tek bunu yazmak zorunda kalmıyacağız.

void İsimYazdir(string ad, string soyad) //metotlar ilk kelime ve ikinci kelime de büyük harfle başlar.
{
    Console.WriteLine($"Ad: {ad}, Soyad: {soyad}");
}
Topla(2, 3);


void Topla(int a, int b)
{
    Console.WriteLine($"{a} + {b} = {a + b}");
}

//faktöriyel diye bir metod yaz int değer alsın ve sonucu ekrana bastırsın.döngüyle yap 5 yazınca 120 versin.

//Faktoriyel(5);
void Faktoriyel(int a)
{
    Console.WriteLine("Lütfen faktöriyeli hesaplanmasını istediğiniz sayıyı giriniz:");
    a = Convert.ToInt32(Console.ReadLine());
    int sonuc = 1;
    for (int i = 1; i <= a; i++)
    {
        sonuc = sonuc * i;
    }
    Console.WriteLine(sonuc);
}
