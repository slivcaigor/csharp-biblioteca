/*

    L’utente deve poter eseguire delle ricerche per codice o per titolo e, eventualmente, prendere in prestito registrando il periodo (Dal/Al) del prestito e il documento.

    Deve essere possibile effettuare la ricerca dei prestiti dato nome e cognome di un utente.

    Contiene inoltre i metodi per le ricerche e per l’aggiunta dei documenti, utenti e prestiti.
*/

namespace csharp_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creazione di un'istanza della classe Biblioteca
            Biblioteca biblioteca = new();

            // Aggiunta di alcuni utenti alla lista degli utenti
            biblioteca.AggiungiUtente(new Utente("Rossi", "Mario", "mario.rossi@mail.com", "password123", "+39 02 1234567"));
            biblioteca.AggiungiUtente(new Utente("Verdi", "Giuseppe", "giuseppe.verdi@mail.com", "password456", "+39 02 7654321"));

            // Aggiunta di alcuni documenti alla lista dei documenti
            biblioteca.AggiungiDocumento(new Libro("LIB0001", "L'archivio segreto del Vaticano", 1972, "Storia", "A1", new Autore("Maria", "Ambrosini"), 397));
            biblioteca.AggiungiDocumento(new DVD("DVD0001", "The Mark Wahlberg: 5-Film Collection", 2015, "Action", "B2", new Autore("Mark", "Wahlberg"), new TimeSpan(10, 23, 0)));

            // Esempio di ricerca di un documento per codice
            string codiceDocumento = "LIB0001";
            Console.WriteLine($"Risultati della ricerca per codice {codiceDocumento}:");
            foreach (Documento documento in biblioteca.CercaPerCodice(codiceDocumento))
            {
                Console.WriteLine($"{documento.titolo} ({documento.anno}) di {documento.autore.nome} {documento.autore.cognome}");
            }

            // Esempio di ricerca di un documento per titolo
            string titoloDocumento = "The Mark Wahlberg: 5-Film Collection";
            Console.WriteLine($"Risultati della ricerca per titolo {titoloDocumento}:");
            foreach (Documento documento in biblioteca.CercaPerTitolo(titoloDocumento))
            {
                Console.WriteLine($"{documento.titolo} ({documento.anno}) di {documento.autore.nome} {documento.autore.cognome}");
            }
        }
    }
}