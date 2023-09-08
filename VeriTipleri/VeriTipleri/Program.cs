var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!"); //tırnak iindeki slaş işareti yerine localhost ayarlanıyor.
{
    
        char x = 'A';
        int y = 89;
        short z = 56;
        long w = 6788;
        uint g = 98; //sadece pozitif tam sayıları ekleriz.
        ushort h = 76;
        double d = 9.9; // ONDALIKLI sayıları temsil eder.
        float f = 7.9808907f;
        decimal c = 5.5453434m; //bu da ondalık sayıdır 128 bitten oluşuyor. 
        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(z);
        Console.WriteLine(w);
        Console.WriteLine(g);
        Console.WriteLine(h);
        Console.WriteLine(d);
        Console.WriteLine(f);
        Console.WriteLine(c);
         


        //referans veri tipleri string;
        String r = "caner";
        r += "sekerci"; // atama operatörüyle canere sekerci yi atadık ve canersekerci oldu. yani referans vererek atama yaptık.
        r = r + "caner"; //
        Console.WriteLine(r); // consola yazdırır.

        //işaratci veri tipi
       // int m = 10;
        // hafızada tutulduğu bellek yerini göstererek atama yapalım.
       // int* p = &m; //belirlediğimiz locasyonu & bu sembolle tutulduğu hafızanın yerini göstermiş ooluyoruz.
                     // buradaki hatayı çözmek için unsafe eklemeliyiz başa.
       // Console.WriteLine("Deger : {0}" +m); // string değerin içine int değer atamak istediğimiz de süsülü içinde 0 yazarak atayabiliyoruz.
       // Console.WriteLine((int)p);


    }

app.Run();
