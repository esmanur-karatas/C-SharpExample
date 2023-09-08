//İF ELSE ELSE İF YAPISI
// == eşit mi
// != esit değil mi

Console.WriteLine("İF ELSE ÖRNEĞİ ÇIKTISI");
int sayi = 20; // sayı değişkenine int bir değer atadık.

if (sayi > 20)// sayi eğer 20 den büyükse 
{
    Console.WriteLine("sayi 20 den büyüktür.");// yukarıdaki koşul doğruysa eğer buradaki metni ekrana yazdırır. değilse bir alt satırdaki else if in içine girer ve koşulu sağlayıp sağlamadığına bakar.
}
else if (sayi == 20)  // sayı değişkeni eğer 20 ye eşitse 
{
    Console.WriteLine("Sayı 20 ye eşittir"); // yukarıdaki koşul doğruysa burayı consola yazdırır. değilse bir alt satırdaki else nin içine girer.
}

else // eğer yukarıdakilerin hiç biri doğru değilse buranın içine girip aşağıda ki consoldaki değeri döndürür.
{
    Console.WriteLine("Sayı 20 den küçüktür.");
}

Console.WriteLine("İF ELSE YAPISI İLE BASİT ORTALAMA HESAPLAMA ÖRNEĞİ");
////VİZE NOTU 55 DEN KÜÇÜKSE KALDINIZ 55 DEN BÜYÜKSE GEÇTİNİZ 100 İSE TAM PUAN ALDINIZ
int vize = 100; //burada vize notu için bir değişken ekledik.
int final = 100; // burada da final için bir değişken ekledik.
int sonuc = (vize + final) / 2; //burada vize ve final notunun ortalamasını aldık.

if (sonuc > 55 && sonuc < 100) // burada sonuc 55 den büyük ve sonuc 100 den küçükse şartını yazdık.
{
    Console.WriteLine($"Ortalamanız {sonuc} Geçtiniz");
    // if in içindeki şartı sağlıyorsa buranın içine girip geçtiniz bastırır.
    // sağlamıyorsa bir alt satıra geçer. 
}
else if (sonuc == 100) // burada sonuç 100 e eşitse eğer 
{
    Console.WriteLine($"Ortalamanız {sonuc} Tam puan aldınız"); //buraya geçer ve ekrana burayı bastırır.
}
else
{
    Console.WriteLine("Kaldınız");
}

Console.WriteLine("KULLANICIDAN VERİ ALARAK YAPTIĞIMIZ İF ELSE ALIŞTIRMASI");

//KULLANICIDAN VERİ ALMA
//Kullanıcıdan yaşını alsın ve ehliyet alıp almadığına bakalım. 18 yaşından küçükse ehliyet alamaz büyükse alır.
Console.WriteLine("Lütfen yaşınızı giriniz: ");
int age = Convert.ToInt32(Console.ReadLine()); // burada bizim consoldan aldığımız bilgileri string olarak alıyoruz burada diyiyoruz ki git bana consolda ki değeri int çevir.
if (age >= 18)
{
    Console.WriteLine("Ehliyet alabilir.");
}
else
{
    Console.WriteLine("ehliyet alamaz");
}

Console.WriteLine("İF ELSE YAPISIYLA HAFTANIN GÜNLERİNİ EKRANA YAZDIRDIK.");

//haftanın 1. günü pazartesi 2. günü salı... 
// bu uygulamada kullanıcıdan 1 ve 7 arası bir değer konsola girmesini isteriz ve seçtiği sayıya göre haftanın günlerini yazdırırız.
// eğer 1 ve 7 arasında bir değer girmezse else bloğunun içindeki yazıyı ekrana basar.
Console.WriteLine("haftanın kaçıncı gününün adını öğrenmek istiyorsunuz");
int day = Convert.ToInt32(Console.ReadLine()); // kullanıcıdan alınan string değeri int veri tipine çevirdik.

if (day <= 5 && day >= 1) // eğer day 5 ve 5 ten küçük ve 1 ve 1 den büyükse ekrana hafta içini yazdırır. 
{
    Console.WriteLine("hafta içi");
}
else if (day >= 6 && day <= 7) //burada da eğer 6 ve 7 arasındaysa ekrana hafta sonunu bastırır.
{
    Console.WriteLine("hafta sonu");
}
if (day == 1) // burada day 1 e eşit ise eğer ekrana günlerden pazartesiyi bastırır değil ise bir alt satırdaki else if e bakar ve bu şekilde else kadar gider.
{
    Console.WriteLine("günlerden pazartesidir.");
}
else if (day == 2)
{
    Console.WriteLine("günlerden salı");
}
else if (day == 3)
{
    Console.WriteLine("günlerden çarşamba");
}
else if (day == 4)
{
    Console.WriteLine("günlerden perşembe");
}
else if (day == 5)
{
    Console.WriteLine("günlerden cuma");
}
else if (day == 6)
{
    Console.WriteLine("günlerden cumartesi");
}
else if (day == 7)
{
    Console.WriteLine("günlerden pazar");
}
else
{
    Console.WriteLine("yanlış değer girdiniz! ");
}

Console.WriteLine("İF ELSE İLE BASİT HESAP MAKİNESİ YAPMANIN 1. YOLU");
//HESAP MAKİNESİ BASİT
Console.WriteLine("Lütfen 1. sayıyı giriniz: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lütfen 2. sayıyı giriniz: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz : \n 1: toplama \n 2: Çıkarma \n 3: Çarpma \n 4: Bölme");
int c = Convert.ToInt32(Console.ReadLine());

if (c == 1)
{
    Console.WriteLine($" İki sayının Toplamı:  {a} + {b} = " + (a + b));
}
else if (c == 2)
{
    Console.WriteLine($" İki Sayının Farkı: {a} - {b} = " + (a - b));
}
else if (c == 3)
{
    Console.WriteLine($" İki Sayının Çarpımı: {a} * {b} = " + (a * b));
}
else if (c == 4)
{
    Console.WriteLine($"İki Sayının Bölümü: {a} / {b} = " + (a / b));
}
else
{
    Console.WriteLine("Hatalı değer girdiniz! Lütfen 1 ve 4 arasında değer giriniz:");
}

Console.WriteLine("2.YOLU");
//2.yol
Console.WriteLine("Lütfen 1. sayıyı giriniz: ");
int sayi1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lütfen 2. sayıyı giriniz: ");
int sayi2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz : \n +: toplama \n -: Çıkarma \n *: Çarpma \n /: Bölme");

string @operator = Console.ReadLine();
if (@operator == "+")
{
    Console.WriteLine($" İki sayının Toplamı:  {sayi1} + {sayi2} = " + (sayi1 + sayi2));
}
else if (@operator == "-")
{
    Console.WriteLine($" İki sayının Farkı:  {sayi1} - {sayi2} = " + (sayi1 - sayi2));
}
else if (@operator == "*")
{
    Console.WriteLine($" İki sayının Çarpımı:  {sayi1} * {sayi2} = " + (sayi1 * sayi2));
}
else if (@operator == "/")
{
    Console.WriteLine($" İki sayının Bölümü:  {sayi1} / {sayi2} = " + (sayi1 / sayi2));
}
else Console.WriteLine("Hatalı değer girdiniz! Lütfen 1 ve 4 arasında değer giriniz:"); // eğer tek satır kod yazacaksak süslü parantez açmamıza gerek yok


Console.WriteLine("SWİTCH CASE");

// SWİCTH CASE:
//else if lerin içindeki değer bir boolean değer olması lazım ama swicth case buna gerek yok kafamıza göre değer verebiliriz mesela if else de sayı eşittir bilmem ne deriz bunda öyle bir zzorunluluk yok bebek.

// SWİTCH CASE İLE HESAP MAKİNESİ YAPMA
Console.WriteLine("Lütfen 1. sayıyı giriniz: ");
int sayi3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lütfen 2. sayıyı giriniz: ");
int sayi4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz : \n +: toplama \n -: Çıkarma \n *: Çarpma \n /: Bölme");
string sonuc1 = Console.ReadLine();
switch (sonuc1)
{
    case "+":
        Console.WriteLine(sayi1 + sayi2);
        break;

    case "-":
        Console.WriteLine(sayi1 - sayi2);
        break;

    case "*":
        Console.WriteLine(sayi1 * sayi2);
        break;

    case "/":
        if (sayi4 == 0)
        {
            Console.WriteLine("İkinci sayı sıfır olamaz ");
        }
        else
        {
            Console.WriteLine("İki sayının Bölümü: " + sayi3 / sayi4);
        }
        break;

    default:
        Console.WriteLine("Hatalı değer girdiniz!");
        break;
}

//katı sıvı gaz sıcaklık 90 sıvı 100 üstü gaz -5 ise katı 
Console.WriteLine("Lütfen sıcaklık değerini giriniz");
int sıcaklık = Convert.ToInt32(Console.ReadLine());

if (sıcaklık == 90)
{
    Console.WriteLine($"Sıcaklık değeri {sıcaklık} derece olduğu için sıvıdır.");
}
else if (sıcaklık == 100 && sıcaklık > 100)
{

    Console.WriteLine($"Sıcaklık değeri {sıcaklık} derece olduğu için gazdır.");
}
else if (sıcaklık < 0)
{

    Console.WriteLine($"Sıcaklık değeri {sıcaklık} derece olduğu için katıdır.");
}
else Console.WriteLine("Yanlış sıcaklık değeri girdiniz!");


//ATLAMA İFADELERİ: break, continue, return, 
//break ifadesi döngüyü bir yerden sonra kırıyor.
// bir if else döngüsü oluşturalım sonrada içinden break le çıkalım. i yi bir değerden başlatalım 1 den 40 a kdr olan sayıları
//azaltarak 1 e eşitlenince döngüden çıksın


for (int i = 40; i > 1; i--) // burada i ye 40 değerini atadık sonra i 1 den büyük olana kadar i yi bir eksilteceğiz.
{
    if (i == 3) // burada da i 3 e eşit olana kadar döngü 1 azalarak çalışacak 
        break; // i 3 e eşit olunca döngü kırılacak ve duracak.
    Console.WriteLine(i); // burada da i yi ekrana bastırdık.
}

//GOTO döngü bizim istediğimiz duruma göre gidiyor. döngüyü biz kontrol etmek istediğimiz zaman bizim istediğimiz yere gidiyor.
//çalışan bloktan sonra bizim ekran çıktımızı istediğimiz yere yönlendiriyor
// continue devam ediyor 

for (int i = 40; i > 1; i--) // burada i ye 40 değerini atadık sonra i 1 den büyük olana kadar i yi bir eksilteceğiz.
{
    if (i == 16) // burada da i yi 16 ya eşitledik alta yazdığımız continue ifadesi 16 yı atlayıp devam ediyor.
        continue; // yukarda yazdığımız koşul sayesinde 16 yı atlayıp döngüye devam ettik.
    Console.WriteLine(i); // burada da i yi ekrana bastırdık.
}

// RETURN döndürme döngümüzü kontrol ederiz. 

//stringlerin içine sayısal değer atamak için {0} koymamız gerekiyor örn: Console.WriteLine("herfbcherb {0}".result ); gibi


//NESNE TABANLI PROGRAMLAMA: CLASS VE NESNE 
// nesneler bir araya gelip sınıfları oluşturuyorlar. 
// nesneler gerçek hayattaki varlıkların oluşumunu temsil eden yapılardır.
// modifers= sınıfın değiştiricileridir.
// keyword class= tür sınıflarının bildirmek için kullanılırlar 
// class identifler= sınıf tanımlayıcılarıdr.
// super class= bir sınıfın önünde : varsa bu sınıfın bir üst sınıfına yani prent (ebeveyn) sınıfına denir.
// ınterface= arayüz sınıf tarafından uygulanabilen arayüzlerin listesine denir.
// Body= {} arasında yazılmış olan kod bloğudur.
// object= gerçek hayattaki varlıkları ifade eder.





