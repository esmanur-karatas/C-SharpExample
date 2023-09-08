//DEĞER DÖNDÜREN METOTLAR: return kullanırız.
//switch case ve fonksşyonları kullanarak basit bir hesap makinesi yapınız:
HesapMakinesi(7, 9, 9);
    void HesapMakinesi(int a, int b, int sonuc)
    {

        Console.WriteLine("Lütfen 1. sayıyı giriniz: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Lütfen 2. sayıyı giriniz: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz: \n1:Toplama \n2:Çıkarma \n3:Çarpma \n4:Bölme");
        sonuc = Convert.ToInt32(Console.ReadLine());
        switch (sonuc)
        {
            case 1:
                Console.WriteLine($"{a} + {b} = {a + b}");
                break;
            case 2:
                Console.WriteLine($"{a} - {b} = {a - b}");
                break;
            case 3:
                Console.WriteLine($"{a} * {b} = {a * b}");
                break;
            case 4:
                Console.WriteLine($"{a} / {b} = {a / b}");

                break;
            default:
                Console.WriteLine("Geçersiz işlem seçimi.");
                break;
        }
    }


