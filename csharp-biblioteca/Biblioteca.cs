using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    // Definizione della classe Biblioteca
    class Biblioteca
    {
        // Definizione delle liste degli utenti, dei documenti e dei prestiti
        public List<Utente> utenti = new();
        public List<Documento> documenti = new();
        public List<Prestito> prestiti = new();


        // Metodo per aggiungere un utente alla lista degli utenti
        public void AggiungiUtente(Utente utente)
        {
            utenti.Add(utente);
        }

        // Metodo per aggiungere un documento alla lista dei documenti
        public void AggiungiDocumento(Documento documento)
        {
            documenti.Add(documento);
        }

        // Metodo per aggiungere un prestito alla lista dei prestiti
        public void AggiungiPrestito(Prestito prestito)
        {
            prestiti.Add(prestito);
        }

        // Metodo per cercare i documenti con un determinato codice
        public List<Documento> CercaPerCodice(string codice)
        {
            List<Documento> risultati = new();
            foreach (Documento documento in documenti)
            {
                if (documento.codice == codice)
                {
                    risultati.Add(documento);
                }
            }
            return risultati;
        }

        // Metodo per cercare i documenti con un determinato titolo
        public List<Documento> CercaPerTitolo(string titolo)
        {
            List<Documento> risultati = new();
            foreach (Documento documento in documenti)
            {
                if (documento.titolo == titolo)
                {
                    risultati.Add(documento);
                }
            }
            return risultati;
        }

        // Metodo per cercare i prestiti effettuati da un determinato utente
        public List<Prestito> CercaPrestitiPerUtente(string cognome, string nome)
        {
            List<Prestito> risultati = new();
            foreach (Prestito prestito in prestiti)
            {
                if (prestito.utente.cognome == cognome && prestito.utente.nome == nome)
                {
                    risultati.Add(prestito);
                }
            }
            return risultati;
        }
    }
}
