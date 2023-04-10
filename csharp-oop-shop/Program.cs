//Nel progetto csharp-oop-shop, creare la classe Prodotto che gestisce i prodotti dello shop.
//Un prodotto è caratterizzato da:
//- codice(numero intero)
//- nome
//- descrizione
//- prezzo
//- iva
//Usate opportunamente i livelli di accesso (public, private), i costruttori, i metodi getter e setter ed eventuali altri metodi di “utilità” per fare in modo che:

//alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random

//Il codice prodotto sia accessibile solo in lettura
//Gli altri attributi siano accessibili sia in lettura che in scrittura

//Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva
//Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome
//Testate poi i vostri oggetti Prodotto, istanziandoli e provando ad interargirci per testare tutti i metodi che avete previsto.

using csharp_oop_shop;
using System.Diagnostics;
using System.Runtime.InteropServices;

Console.WriteLine("Numero prodotti:");
int productsNum = Convert.ToInt32(Console.ReadLine());

Product[] products = new Product[productsNum];

for (int i = 0; i < productsNum; i++)
{
    Console.WriteLine($"inserire nome prodotto {i + 1}:");
    string name = Console.ReadLine();
     
    Console.WriteLine($"inserire descrizione prodotto {i + 1}:");
    string description = Console.ReadLine();

    Console.WriteLine($"inserire prezzo prodotto {i + 1}:");
    double price = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine($"inserire iva prodotto {i + 1}:");
    byte iva = (byte)Convert.ToInt32(Console.ReadLine());


    Product _object = new Product(name, description, price, iva);

    products[i] = _object;
}


Console.WriteLine("LISTA PRODOTTI:");

for (int i = 0; i < products.Length; i++)
{
    Console.WriteLine(products[i].ToString());
}



namespace csharp_oop_shop
{
    //classe
    public class Product
    {
        //simplified
        public string Code { get; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public byte Iva { get; set; }

        ////not simplified
        //public byte Iva;
        //public byte GetIva()
        //{
        //    return this.iva;
        //}
        //public void SetIva(byte iva)
        //{
        //    this.iva = iva;
        //}

        public Product(string name, string description, double price, byte iva)
        {
            Code = CreateCode();
            Name = name;
            Description = description;
            Price = price;
            Iva = iva;
        }

        //metodi
        public static string CreateCode()
        {
            var code = new Random().Next(0, 1000);

            return code.ToString().PadLeft(8, '0');
        }

        public double PriceIva()
        {
            var price_iva = (Price / (100 * 100)) * ((Iva + 100) * 100);

            return price_iva;
        }

        public string NameCode()
        {
            var result = $"{Code} | {Name}";

            return result;
        }

        public override string ToString()
        {
            var nl = Environment.NewLine;

            var productWrite = 
                $"Nome prodotto: {Name}" + nl
                + $"Descrizione prodotto: {Description}" + nl
                + $"Prezzo prodotto: {Price} euro" + nl
                + $"IVA: {Iva} %" + nl
                + $"Prezzo + IVA: {PriceIva()} euro";

            return productWrite;
        }
    }
}