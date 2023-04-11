using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    // Definizione della classe Utente
    class Utente
    {
        // Definizione delle proprietà dell'utente
        public string cognome;
        public string nome;
        public string email;
        public string password;
        public string telefono;

        // Costruttore della classe Utente
        public Utente(string cognome, string nome, string email, string password, string telefono)
        {
            // Inizializzazione delle proprietà dell'utente
            this.cognome = cognome;
            this.nome = nome;
            this.email = email;
            this.password = password;
            this.telefono = telefono;
        }

       
    }
}
