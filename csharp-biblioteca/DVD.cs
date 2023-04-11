using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    // Definizione della classe DVD, che eredita dalla classe Documento
    class DVD : Documento
    {
        // Definizione della proprietà aggiuntiva del DVD
        public TimeSpan durata;

        // Costruttore della classe DVD
        public DVD(string codice, string titolo, int anno, string settore, string scaffale, Autore autore, TimeSpan durata)
            : base(codice, titolo, anno, settore, scaffale, autore)
        {
            // Inizializzazione della proprietà aggiuntiva del DVD
            this.durata = durata;
        }
    }
}
