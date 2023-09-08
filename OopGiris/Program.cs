//e ticaret sistemimiz var ve bu sistemde ürün kaydı yapmamız isteniyor.
//ürün adı üretcisi fiyatı stok açıklama.
using OopGiris.models;
Product product = new Product();
Product product2 = new();
// reflection yöntemi ile nesne oluşturma.
product.name = "Ürün1";
product.producer = "seyfi yalçıntaş";
product.description = " 9 yıl oldu";
product.price = 10;
product.stock = 10;

Console.WriteLine(product);
var product1 = new Product("Bilgisayar", "Vatan Computer", 20, 10, "Biilgisayar");
Console.WriteLine(product1);