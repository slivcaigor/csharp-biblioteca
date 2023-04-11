using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{

    // Definizione della classe Prestito
    class Prestito
    {
        // Definizione delle proprietà del prestito
        public Utente utente;
        public Documento documento;
        public DateTime dal;
        public DateTime al;

        // Costruttore della classe Prestito
        public Prestito(Utente utente, Documento documento, DateTime dal, DateTime al)
        {
            // Inizializzazione delle proprietà del prestito
            this.utente = utente;
            this.documento = documento;
            this.dal = dal;
            this.al = al;
        }
    }
}
