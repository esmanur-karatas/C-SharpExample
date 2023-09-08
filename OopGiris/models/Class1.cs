using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopGiris.models; // buraya noktalı vigül koyunca süslü parantezi kaldırıyor.

public class Product
{
    public Product() : base() //base bir üst classtaki verileri alır en baştaki class ı değil.
    {
    
    }
    public Product(string name, string producer, decimal price, int stock, string description) 
    {
        // biz bir classta ana class taki bir metoda ulaşmak istiyorsak base kullanılır.
        // this sadece o class ta.
    this.name = name; //burada this yerine _name=name; şeklinde kullanabiliriz ve normalde {this.name} yazan yere de {_name} yazabiliriz. genelde c# da bu kullanılır.
    this.producer = producer;
    this.stock = stock;
    this.description = description;
    this.price = price;
    }
    public string name;
    public string producer;
    public decimal price;
    public int stock;
    public string description;

    public override string ToString()
    {
        return $"Ürün Adı:{this.name}, Sağlayıcı: {this.producer}, Değeri: {this.price}, Stok: {this.stock}, Açıklama:{this.description}"; 
    }
}
