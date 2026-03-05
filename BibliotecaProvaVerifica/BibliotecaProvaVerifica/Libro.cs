using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaProvaVerifica
{
    internal class Libro
    {
        public string Titolo { get; set; }
        public string Autore { get; set; }
        public int AnnoPubblicazione { get; set; }
        public string Genere { get; set; }

        public Libro(string titolo, string autore, int annoPubblicazione, string genere)
        {
            Titolo = titolo;
            Autore = autore;
            AnnoPubblicazione = annoPubblicazione;
            Genere = genere;
        }
    }
}
