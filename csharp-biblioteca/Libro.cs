using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    // Definizione della classe Libro, che eredita dalla classe Documento
    class Libro : Documento
    {
        // Definizione della proprietà aggiuntiva del libro
        public int pagine;

        // Costruttore della classe Libro
        public Libro(string codice, string titolo, int anno, string settore, string scaffale, Autore autore, int pagine)
            : base(codice, titolo, anno, settore, scaffale, autore)
        {
            // Inizializzazione della proprietà aggiuntiva del libro
            this.pagine = pagine;
        }
    }
}
