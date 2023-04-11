/*
    prendere in prestito registrando il periodo (Dal/Al) del prestito e il documento.
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

            // Esempio di prestito di un documento a un utente
            Utente utente = biblioteca.utenti[0];
            Documento documentoDaPrendereInPrestito1 = biblioteca.documenti[0];
            DateTime dal1 = DateTime.Now;
            DateTime al1 = dal1.AddDays(7);
            Prestito prestito1 = new(utente, documentoDaPrendereInPrestito1, dal1, al1);
            biblioteca.AggiungiPrestito(prestito1);

            Documento documentoDaPrendereInPrestito2 = biblioteca.documenti[1];
            DateTime dal2 = DateTime.Now;
            DateTime al2 = dal2.AddDays(5);
            Prestito prestito2 = new(utente, documentoDaPrendereInPrestito2, dal2, al2);
            biblioteca.AggiungiPrestito(prestito2);


            // Esempio di ricerca dei prestiti effettuati da un utente
            string cognomeUtente = "Rossi";
            string nomeUtente = "Mario";
            Console.WriteLine($"Risultati della ricerca dei prestiti di {nomeUtente} {cognomeUtente}:");
            foreach (Prestito prestitoCorrente in biblioteca.CercaPrestitiPerUtente(cognomeUtente, nomeUtente))
            {
                Console.WriteLine($"{prestitoCorrente.documento.titolo} ({prestitoCorrente.documento.anno}) di {prestitoCorrente.documento.autore.nome} {prestitoCorrente.documento.autore.cognome} (dal {prestitoCorrente.dal.ToShortDateString()} al {prestitoCorrente.al.ToShortDateString()})");
            }


            // Attesa di un input dall'utente prima di chiudere la console
            Console.WriteLine("Premi un tasto per uscire...");
            Console.ReadKey();
        }
    }
}