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

namespace csharp_oop_shop
{
    public class Prodotto
    {
        //attributi (caratteristiche)
        public int codice;
        public string nome;
        public string? descrizione;
        public float prezzo;
        public byte iva;

        public Prodotto(int codice
        string nome
        string? descrizione
        float prezzo
        byte iva
)
        {
            codice = 123;
            
            
        }
    }
}










