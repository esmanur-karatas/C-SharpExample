
// COLLECTİONS ARRAYLER 
// bir array tanımlamak istersek önce veri tipini yazıyoruz. arraylerde çoğul bir veriyle çalışacaksak köşeli parantez açıp kapatıyoruz. sonra süslü parantez açıp değerleri giriyoruz.
int[] sayilar = { 1, 2, 3, 6, 7, 8, 9, 12, 32 };
Console.WriteLine($"3.Sayi {sayilar[2]}");
Console.WriteLine($"Dizini Boyutu: {sayilar.Length}");
Console.WriteLine($"Dizini en büyük elemanı: {sayilar.Max()}");
Console.WriteLine($"Dizinin küçükten en küçük elemanı: {sayilar.Min()}");
Console.WriteLine($"Dizinin Tipi Nedir: {sayilar.GetType()}");

//eğer referans tiplerle çalışmak istersek bunu new lememiz gerekir.
List<int> sayilarListesi = new List<int>() { 1, 2, 3 }; //manuel integer sayılar listesi oluşturduk burada
sayilarListesi.Add(2); // burada sayilar listesine 2 ekledik.
sayilarListesi.Remove(3);// burada listeden 3 ü çıkardık.
Console.WriteLine($"sayilar listesinin boyutu: {sayilarListesi.Count}");

//generic programlama tip güvenliği olan bir dildir c#. Bunu araştır.
List<String> sehirler = new(); // c# 10 ile gelen bir özellik ve yukarıdaki gibi uzun uzun yazmamıza gerek yok.
sehirler.Add("Elazığ");
sehirler.Add("Malatya");
sehirler.Add("Bingö");
sehirler.Add("Tunceli");
Console.WriteLine($"sehirler Listesinin Boyutu: {sehirler.Count}"); // listeler de genelde count kullanılır diziler de ise lenght kullanılır.
Console.WriteLine(sehirler);


//FOR DÖNGÜSÜ
for(int i = 0; i < sehirler.Count; i++) // o dan başla sehirlerin i++ yerine i+= de yazabiliriz.
{
    Console.WriteLine($"{i + 1}. sehir = {sehirler[i]}");
}


//FOREACH DÖNGÜSÜ
foreach(String sehir in sehirler) // sen bu listeyi teker teker gez ve git bunu teker teker dön ve bu değişkene ata
{
    Console.WriteLine(sehir);
}

//MEYVE LİSTESİ TUTAN BİR LİSTE OLUŞTURUN VE EKRANA BÜTÜN MEYVELERİ YAZDIRIN
List<String> meyve = new();
meyve.Add("Çilek");
meyve.Add("Karpuz");
meyve.Add("Kivi");
meyve.Add("Kavun");
foreach (String meyveler in meyve)
{
    Console.WriteLine(meyve);
}


//BİR SINAV NOT LİSTESİ OLSUN VE BU SINAV NOTU LİSTESİNİ FOR İLE EKRANA YAZDIRIN

List<int> sinav = new List<int>() { 100, 20, 30, 89, 90 };
for (int i = 0; i < sinav.Count; i++)
{
    Console.WriteLine($"{i + 1}. sınav notu = {sinav[i]}");
}
// MEYVE LİSTESİ TUTAN BİR LİSTE OLUŞTURUN VE EKRANA BÜTÜN MEYVELERİ YAZDIRIN FOREACH İLE
List<string> meyve = new();
meyve.Add("Çilek");
meyve.Add("Karpuz");
meyve.Add("Kivi");
meyve.Add("Kavun");
foreach (string meyveler in meyve)
{
    Console.WriteLine(meyveler);
}


// BİR SINAV NOT LİSTESİ OLSUN VE BU SINAV NOTU LİSTESİNİ FOR İLE EKRANA YAZDIRIN

List<int> sinav = new List<int>() { 100, 20, 30, 89, 90 };
for (int i = 0; i < sinav.Count; i++)
{
    Console.WriteLine($"{i + 1}. sınav notu = {sinav[i]}");
}

//LİSTELERİN KENDİNE GÖRE FOR YA DA FOREACH KULLANMADAN DA YAZABİLİRİZ.
//İKİNCİ YÖNTEM

meyve.ForEach(meyveler => Console.WriteLine(meyveler)); // labda fonsiyonu  bize tüm meyveleri bastırır.
//LINQ LANGUAGE INTEGRATED QUERY:  bizim yerimize c# sql sorgularını kendi kendine sql kullanmadan çevirir araştır. 


// ELİMİZDE BİR TANE LİSTE OLSUN BU LİSTEDE ÇİFT SAYI OLANLARI FARKLI BİR LİSTE ATSIN VE O ÇİFT SAYI LİSTESİNİ EKRANA BASSIN
List<int> numbers = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
List<int> evenNumbers = new();
List<int> oddNumbers = new();
//foreach (int number in numbers) // bütün numaraları teker teker gez
//{
//    if(number % 2 == 0) // numberın 2 ye bölümünden kalan eşittir sıfır ise
//    {
//        evenNumbers.Add(number);
//    }
//    else
//    {
//        oddNumbers.Add(number);
//    }
//}

// FOREACH YERİNE DAHA BASİT BİR YÖNTEMİ VAR.
//2.YOL
oddNumbers = numbers.FindAll(odd => odd % 2 != 0); // findAll ne demek araştır. => bu sembol bize bir kural fonksiyon yaz demek.
evenNumbers = numbers.FindAll(o => o % 2 == 0);
Console.WriteLine("Çift Sayılar");
evenNumbers.ForEach(even => Console.WriteLine(even));// burada git yukarıdaki evenNumber içindeki tüm sayıları gez ve even ı ekrana bas.

Console.WriteLine("Tek Sayılar");
oddNumbers.ForEach(odd => Console.WriteLine(odd));

