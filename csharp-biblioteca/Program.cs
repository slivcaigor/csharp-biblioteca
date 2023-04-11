
using csharp_biblioteca;
using System.Text.RegularExpressions;


namespace csharp_biblioteca
{
    class Program
    {

        static void Main(string[] args)
        {

            // Creazione di un'istanza della classe Biblioteca
            Biblioteca biblioteca = new();

            // Aggiunta di alcuni libri alla lista dei documenti
            biblioteca.AggiungiDocumento(new Libro("LIB0000", "L'archivio segreto del Vaticano", 1972, "Storia", "A1", new Autore("Maria", "Ambrosini"), 397));
            biblioteca.AggiungiDocumento(new Libro("LIB0001", "Il nome della rosa", 1980, "Storia", "A2", new Autore("Umberto", "Eco"), 512));
            biblioteca.AggiungiDocumento(new Libro("LIB0002", "Il signore degli anelli: La compagnia dell'anello", 1954, "Fantasy", "B1", new Autore("J.R.R.", "Tolkien"), 576));
            biblioteca.AggiungiDocumento(new Libro("LIB0003", "Cronache del ghiaccio e del fuoco: Il gioco del trono", 1996, "Fantasy", "B2", new Autore("George R.R.", "Martin"), 807));
            biblioteca.AggiungiDocumento(new Libro("LIB0004", "Il ritratto di Dorian Gray", 1890, "Romanzo", "C1", new Autore("Oscar", "Wilde"), 254));
            biblioteca.AggiungiDocumento(new Libro("LIB0005", "1984", 1949, "Romanzo", "C2", new Autore("George", "Orwell"), 328));
            biblioteca.AggiungiDocumento(new Libro("LIB0006", "Il vecchio e il mare", 1952, "Romanzo", "D1", new Autore("Ernest", "Hemingway"), 127));
            biblioteca.AggiungiDocumento(new Libro("LIB0007", "Orgoglio e pregiudizio", 1813, "Romanzo", "D2", new Autore("Jane", "Austen"), 432));
            biblioteca.AggiungiDocumento(new Libro("LIB0008", "Harry Potter e la pietra filosofale", 1997, "Fantasy", "E1", new Autore("J.K.", "Rowling"), 223));
            biblioteca.AggiungiDocumento(new Libro("LIB0009", "Il codice da Vinci", 2003, "Romanzo", "E2", new Autore("Dan", "Brown"), 608));

            // Aggiunta di alcuni DVD alla lista dei documenti
            biblioteca.AggiungiDocumento(new DVD("DVD0000", "The Mark Wahlberg: 5-Film Collection", 2015, "Action", "B2", new Autore("Mark", "Wahlberg"), new TimeSpan(10, 23, 0)));
            biblioteca.AggiungiDocumento(new DVD("DVD0001", "The Dark Knight Trilogy", 2012, "Action", "C1", new Autore("Christopher", "Nolan"), new TimeSpan(7, 0, 0)));
            biblioteca.AggiungiDocumento(new DVD("DVD0002", "The Godfather Collection", 2008, "Drama", "D3", new Autore("Francis Ford", "Coppola"), new TimeSpan(9, 0, 0)));
            biblioteca.AggiungiDocumento(new DVD("DVD0003", "The Lord of the Rings Trilogy", 2004, "Fantasy", "E2", new Autore("Peter", "Jackson"), new TimeSpan(12, 0, 0)));
            biblioteca.AggiungiDocumento(new DVD("DVD0004", "The Matrix Trilogy", 2004, "Action", "F4", new Autore("Lana", "Wachowski"), new TimeSpan(7, 30, 0)));
            biblioteca.AggiungiDocumento(new DVD("DVD0005", "The Bourne Trilogy", 2010, "Action", "A1", new Autore("Paul", "Greengrass"), new TimeSpan(8, 0, 0)));
            biblioteca.AggiungiDocumento(new DVD("DVD0006", "The James Bond Collection", 2016, "Action", "B3", new Autore("Sam", "Mendes"), new TimeSpan(14, 0, 0)));
            biblioteca.AggiungiDocumento(new DVD("DVD0007", "The Harry Potter Collection", 2011, "Fantasy", "C2", new Autore("David", "Yates"), new TimeSpan(19, 0, 0)));
            biblioteca.AggiungiDocumento(new DVD("DVD0008", "The Star Wars Collection", 2015, "Science Fiction", "D1", new Autore("George", "Lucas"), new TimeSpan(20, 30, 0)));
            biblioteca.AggiungiDocumento(new DVD("DVD0009", "The Jurassic Park Collection", 2015, "Science Fiction", "F1", new Autore("Steven", "Spielberg"), new TimeSpan(10, 0, 0)));

            // Mostra un messaggio di benvenuto e chiede all'utente di scegliere la modalità di ricerca
            //Console.WriteLine("Benvenuto nella Biblioteca! Scegli la modalità di ricerca:\n1. Ricerca per codice\n2. Ricerca per titolo");


            while (true)
            {
                Console.WriteLine("Seleziona un'opzione:");
                Console.WriteLine("1. Registrati");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Esci");

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                int scelta = -1;

                if (keyInfo.KeyChar >= '1' && keyInfo.KeyChar <= '3')
                {
                    scelta = (int)Char.GetNumericValue(keyInfo.KeyChar);
                }

                Console.Clear();

                switch (scelta)
                {

                    case 1:
                        Console.Clear();

                        Regex regexLettere = new(@"^[a-zA-Z]+$");
                        Regex regexNumeri = new(@"^\d+$");
                        Regex regexEmail = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
                        string cognome, nome, email, password, telefono;

                        do
                        {
                            Console.Write("Inserisci il tuo cognome: ");
                            cognome = Console.ReadLine() ?? string.Empty;

                            if (string.IsNullOrWhiteSpace(cognome) || !regexLettere.IsMatch(cognome))
                            {
                                Console.WriteLine("Inserisci un cognome valido senza numeri e simboli");
                            }
                        } while (string.IsNullOrWhiteSpace(cognome) || !regexLettere.IsMatch(cognome));

                        do
                        {
                            Console.Write("Inserisci il tuo nome: ");
                            nome = Console.ReadLine() ?? string.Empty;

                            if (string.IsNullOrWhiteSpace(nome) || !regexLettere.IsMatch(nome))
                            {
                                Console.WriteLine("Inserisci un nome valido senza numeri e simboli");
                            }
                        } while (string.IsNullOrWhiteSpace(nome) || !regexLettere.IsMatch(nome));

                        do
                        {
                            Console.Write("Inserisci la tua email: ");
                            email = Console.ReadLine() ?? string.Empty;

                            if (string.IsNullOrWhiteSpace(email) || !regexEmail.IsMatch(email))
                            {                            
                                Console.WriteLine("Inserisci una email valida");
                            }
                        } while (string.IsNullOrWhiteSpace(email) || !regexEmail.IsMatch(email));

                        do
                        {
                            Console.Write("Inserisci la tua password: ");
                            password = Console.ReadLine() ?? string.Empty;

                            if (string.IsNullOrWhiteSpace(password))
                            {                       
                                Console.WriteLine("Inserisci una password valida");
                            }
                        } while (string.IsNullOrWhiteSpace(password));

   

                        do
                        {
                            Console.Write("Inserisci il tuo numero di telefono: ");
                            telefono = Console.ReadLine() ?? string.Empty;
                        } while (string.IsNullOrWhiteSpace(telefono) || !regexNumeri.IsMatch(telefono));

                        Utente nuovoUtente = biblioteca.RegistraUtente(cognome, nome, email, password, telefono);
                        Console.WriteLine($"Utente registrato con successo: {nuovoUtente.nome} {nuovoUtente.cognome}");
                        break;

                    case 2:

                        do
                        {
                            Console.Write("Inserisci la tua email: ");
                            email = Console.ReadLine() ?? string.Empty;

                            if (string.IsNullOrWhiteSpace(email))
                            {
                                Console.WriteLine("Inserisci una email valida");
                            }
                        } while (string.IsNullOrWhiteSpace(email));


                        do
                        {
                            Console.Write("Inserisci la password email: ");
                            password = Console.ReadLine() ?? string.Empty;

                            if (string.IsNullOrWhiteSpace(password))
                            {
                                Console.WriteLine("Inserisci una email valida");
                            }
                        } while (string.IsNullOrWhiteSpace(password));



                        Utente? utenteLoggato = biblioteca.Login(email, password);


                        if (utenteLoggato != null)
                        {
                            Console.Clear();
                            Console.WriteLine($"Benvenuto {utenteLoggato.nome} {utenteLoggato.cognome}!");

                            // Nuovo menu dopo il login
                            bool continua = true;
                            while (continua)
                            {
                                Console.WriteLine("\nSeleziona un'opzione:");
                                Console.WriteLine("1. Ricerca per codice");
                                Console.WriteLine("2. Ricerca per titolo");
                                Console.WriteLine("3. Prestito");
                                Console.WriteLine("4. Esci");

                                ConsoleKeyInfo sceltaMenu = Console.ReadKey();
                                Console.Clear();

                                // Il tuo codice per la ricerca per codice e per titolo viene inserito qui
                                // con alcune modifiche per adattarlo al nuovo menu
                                switch (sceltaMenu.KeyChar)
                                {
                                    case '1':
                                        // Pulisce la console
                                        Console.Clear();
                                        // Chiede all'utente di inserire il codice del libro o DVD da cercare
                                        Console.Write("Inserisci il codice del libro o DVD da cercare (formato: LIB0001 per i libri e DVD0001 per i DVD): ");
                                        // Legge l'input dell'utente e lo memorizza nella variabile "codice"
                                        string codice = Console.ReadLine() ?? string.Empty;

                                        // Verifica che il codice inserito sia nel formato corretto (LIBxxxx o DVDxxxx)
                                        Regex regexCodice = new(@"^(LIB|DVD)\d{4}$");
                                        while (!regexCodice.IsMatch(codice))
                                        {
                                            // Se il formato non è corretto, chiede all'utente di inserire nuovamente il codice
                                            Console.WriteLine("Formato del codice non valido (formato: LIB0001 per i libri e DVD0001 per i DVD): ");
                                            codice = Console.ReadLine() ?? string.Empty;
                                        }

                                        // Mostra i risultati della ricerca per codice
                                        Console.WriteLine($"Risultati della ricerca per codice {codice}:");
                                        foreach (Documento documento in biblioteca.CercaPerCodice(codice))
                                        {
                                            Console.WriteLine($"{documento.titolo} ({documento.anno}) di {documento.autore.nome} {documento.autore.cognome}");
                                        }
                                        break;
                                    case '2':
                                        // Pulisce la console
                                        Console.Clear();
                                        // Chiede all'utente di inserire il titolo del libro o DVD da cercare
                                        Console.Write("Inserisci il titolo del libro o DVD da cercare: ");
                                        // Legge l'input dell'utente e lo memorizza nella variabile "titolo"
                                        string titolo = Console.ReadLine() ?? string.Empty;

                                        // Continua a chiedere all'utente di inserire un titolo valido finché l'input non è corretto
                                        while (string.IsNullOrWhiteSpace(titolo))
                                        {
                                            Console.WriteLine("Titolo non valido. Inserisci un titolo valido: ");
                                            titolo = Console.ReadLine() ?? string.Empty;
                                        }

                                        Console.WriteLine($"Risultati della ricerca per titolo \"{titolo}\":");

                                        // Mostra i risultati della ricerca per titolo
                                        List<Documento> documentiTrovati = biblioteca.CercaPerTitolo(titolo);
                                        if (documentiTrovati.Count == 0)
                                        {
                                            Console.WriteLine("Nessun risultato trovato.");
                                        }
                                        else
                                        {
                                            foreach (Documento documento in documentiTrovati)
                                            {
                                                Console.WriteLine($"{documento.titolo} ({documento.anno}) di {documento.autore.nome} {documento.autore.cognome}");
                                            }
                                        }
                                        break;
                                    case '3':
                                        // Codice per il prestito
                                        break;
                                    case '4':
                                        continua = false;
                                        break;
                                    default:
                                        Console.WriteLine("Scelta non valida. Riprova.");
                                        break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Email o password non corrette.");
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Arrivederci!");
                        return;
                    default:
                        Console.WriteLine("Opzione non valida. Riprova.");
                        break;
                }
            }


        }
    }
}
