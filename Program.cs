using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)  //entry point
        {
            //prima versione
            /*Console.WriteLine("Scrivere due numeri per ottenere il prodotto");

            Console.WriteLine("Scrivere il primo numero: ");

            string sval1 = Console.ReadLine();

            Console.WriteLine("Scrivere il secondo numero: ");

            string sval2 = Console.ReadLine();

            int snum1 = int.Parse(sval1);

            int snum2 = int.Parse(sval2);

            int prodotto = snum1 * snum2;

            Console.WriteLine("Il prodotto dei due numeri è {0} ", prodotto);
            */

            // versione con gestione degli errori :
            int v1, v2;
            Console.Write("Inserisci un numero : ");
            if (!int.TryParse(Console.ReadLine(), out v1)) 
            {
                Console.WriteLine("Errore non è un numero");
                Environment.Exit(1);
            }
            Console.Write("Inserisci un numero : ");
            if (!int.TryParse(Console.ReadLine(), out v2))
            {
                Console.WriteLine("Errore non è un numero");
                Environment.Exit(1);
            }
            Console.WriteLine("La moltiplicazione dei due numeri è {0} ",
               Prodotto(v1,v2) ); //richiama il metodo moltiplica

        }
        static int Prodotto(int v1, int v2)
        { 
            return v1 * v2;
        }
       
    }
}