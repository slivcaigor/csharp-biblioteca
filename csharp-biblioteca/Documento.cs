using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    // Definizione della classe Documento
    class Documento
    {
        // Definizione delle proprietà del documento
        public string codice;
        public string titolo;
        public int anno;
        public string settore;
        public string scaffale;
        public Autore autore;

        // Costruttore della classe Documento
        public Documento(string codice, string titolo, int anno, string settore, string scaffale, Autore autore)
        {
            // Inizializzazione delle proprietà del documento
            this.codice = codice;
            this.titolo = titolo;
            this.anno = anno;
            this.settore = settore;
            this.scaffale = scaffale;
            this.autore = autore;
        }
    }
}
