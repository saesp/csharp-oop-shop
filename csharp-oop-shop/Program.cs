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
    //classe
    public class Prodotto
    {
        //attributi (caratteristiche)
        public int codice;
        public string nome;
        public string? descrizione;
        public float prezzo;
        public byte iva;


        public Prodotto(int _codice, string _nome, string? _descrizione, float _prezzo, byte _iva)
        {
            this.codice = _codice;
            this.nome = _nome;
            this.descrizione = _descrizione;
            this.prezzo = _prezzo;
            this.iva = _iva;
        }


        //metodi
        public int[] RandomCode()
        {
            Random rnd = new Random();

            int[] code = new int[5]; 

            for (int i = 0; i<5; i++)
            {
                int number = rnd.Next(0, 9);
                code[i] = number; 
            }

            return code;
        }

        public float PrezzoIva()
        {
            float prezzo_iva = (prezzo / (100 * 100)) * ((iva + 100) * 100);

            return prezzo_iva; 
        }
    }
}












