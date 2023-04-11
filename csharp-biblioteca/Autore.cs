using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    // Definizione della classe Autore
    class Autore
    {
        // Definizione delle proprietà dell'autore
        public string nome;
        public string cognome;

        // Costruttore della classe Autore
        public Autore(string nome, string cognome)
        {
            // Inizializzazione delle proprietà dell'autore
            this.nome = nome;
            this.cognome = cognome;
        }
    }
}
