
// Creazione di un'istanza della classe Biblioteca
using csharp_biblioteca;
using System.Text.RegularExpressions;

Biblioteca biblioteca = new();

// Aggiunta di alcuni libri alla lista dei documenti
biblioteca.AggiungiDocumento(new Libro("LIB0001", "L'archivio segreto del Vaticano", 1972, "Storia", "A1", new Autore("Maria", "Ambrosini"), 397));
biblioteca.AggiungiDocumento(new Libro("LIB0002", "Il nome della rosa", 1980, "Storia", "A2", new Autore("Umberto", "Eco"), 512));
biblioteca.AggiungiDocumento(new Libro("LIB0003", "Il signore degli anelli: La compagnia dell'anello", 1954, "Fantasy", "B1", new Autore("J.R.R.", "Tolkien"), 576));
biblioteca.AggiungiDocumento(new Libro("LIB0004", "Cronache del ghiaccio e del fuoco: Il gioco del trono", 1996, "Fantasy", "B2", new Autore("George R.R.", "Martin"), 807));
biblioteca.AggiungiDocumento(new Libro("LIB0005", "Il ritratto di Dorian Gray", 1890, "Romanzo", "C1", new Autore("Oscar", "Wilde"), 254));
biblioteca.AggiungiDocumento(new Libro("LIB0006", "1984", 1949, "Romanzo", "C2", new Autore("George", "Orwell"), 328));
biblioteca.AggiungiDocumento(new Libro("LIB0007", "Il vecchio e il mare", 1952, "Romanzo", "D1", new Autore("Ernest", "Hemingway"), 127));
biblioteca.AggiungiDocumento(new Libro("LIB0008", "Orgoglio e pregiudizio", 1813, "Romanzo", "D2", new Autore("Jane", "Austen"), 432));
biblioteca.AggiungiDocumento(new Libro("LIB0009", "Harry Potter e la pietra filosofale", 1997, "Fantasy", "E1", new Autore("J.K.", "Rowling"), 223));
biblioteca.AggiungiDocumento(new Libro("LIB0010", "Il codice da Vinci", 2003, "Romanzo", "E2", new Autore("Dan", "Brown"), 608));

// Aggiunta di alcuni DVD alla lista dei documenti
biblioteca.AggiungiDocumento(new DVD("DVD0001", "The Mark Wahlberg: 5-Film Collection", 2015, "Action", "B2", new Autore("Mark", "Wahlberg"), new TimeSpan(10, 23, 0)));
biblioteca.AggiungiDocumento(new DVD("DVD0002", "The Dark Knight Trilogy", 2012, "Action", "C1", new Autore("Christopher", "Nolan"), new TimeSpan(7, 0, 0)));
biblioteca.AggiungiDocumento(new DVD("DVD0003", "The Godfather Collection", 2008, "Drama", "D3", new Autore("Francis Ford", "Coppola"), new TimeSpan(9, 0, 0)));
biblioteca.AggiungiDocumento(new DVD("DVD0004", "The Lord of the Rings Trilogy", 2004, "Fantasy", "E2", new Autore("Peter", "Jackson"), new TimeSpan(12, 0, 0)));
biblioteca.AggiungiDocumento(new DVD("DVD0005", "The Matrix Trilogy", 2004, "Action", "F4", new Autore("Lana", "Wachowski"), new TimeSpan(7, 30, 0)));
biblioteca.AggiungiDocumento(new DVD("DVD0006", "The Bourne Trilogy", 2010, "Action", "A1", new Autore("Paul", "Greengrass"), new TimeSpan(8, 0, 0)));
biblioteca.AggiungiDocumento(new DVD("DVD0007", "The James Bond Collection", 2016, "Action", "B3", new Autore("Sam", "Mendes"), new TimeSpan(14, 0, 0)));
biblioteca.AggiungiDocumento(new DVD("DVD0008", "The Harry Potter Collection", 2011, "Fantasy", "C2", new Autore("David", "Yates"), new TimeSpan(19, 0, 0)));
biblioteca.AggiungiDocumento(new DVD("DVD0009", "The Star Wars Collection", 2015, "Science Fiction", "D1", new Autore("George", "Lucas"), new TimeSpan(20, 30, 0)));
biblioteca.AggiungiDocumento(new DVD("DVD0010", "The Jurassic Park Collection", 2015, "Science Fiction", "F1", new Autore("Steven", "Spielberg"), new TimeSpan(10, 0, 0)));

Console.WriteLine("Benvenuto nella Biblioteca! Scegli la modalità di ricerca:\n1. Ricerca per codice\n2. Ricerca per titolo");
string scelta = Console.ReadLine() ?? string.Empty;

while (scelta != "1" && scelta != "2")
{
    Console.WriteLine("Scelta non valida. Inserisci 1 per la ricerca per codice o 2 per la ricerca per titolo.");
    scelta = Console.ReadLine() ?? string.Empty;
}

if (scelta == "1")
{
    Console.Write("Inserisci il codice del libro o DVD da cercare (formato: LIB0001 per i libri e DVD0001 per i DVD): ");
    string codice = Console.ReadLine() ?? string.Empty;

    // Verifica se il codice è nel formato corretto
    Regex regexCodice = new(@"^(LIB|DVD)\d{4}$");
    while (!regexCodice.IsMatch(codice))
    {
        Console.WriteLine("Formato del codice non valido (formato: LIB0001 per i libri e DVD0001 per i DVD): ");
        codice = Console.ReadLine() ?? string.Empty;
    }

    Console.WriteLine($"Risultati della ricerca per codice {codice}:");
    foreach (Documento documento in biblioteca.CercaPerCodice(codice))
    {
        Console.WriteLine($"{documento.titolo} ({documento.anno}) di {documento.autore.nome} {documento.autore.cognome}");
    }
}
else if (scelta == "2")
{
    Console.Write("Inserisci il titolo del libro da cercare: ");
    string titolo = Console.ReadLine() ?? string.Empty;

    Console.WriteLine($"Risultati della ricerca per titolo {titolo}:");
    foreach (Documento documento in biblioteca.CercaPerTitolo(titolo))
    {
        Console.WriteLine($"{documento.titolo} ({documento.anno}) di {documento.autore.nome} {documento.autore.cognome}");
    }
}



Console.ReadLine();
