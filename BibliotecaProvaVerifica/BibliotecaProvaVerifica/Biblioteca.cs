using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaProvaVerifica
{
    internal class Biblioteca
    {
        public string Nome { get; set; }
        public string Indirizzo { get; set; }
        public string OrarioApertura { get; set; }
        public string OrarioChiusura { get; set; }

        private List<Libro> elencoLibri;

        public Biblioteca(string nome, string indirizzo, string apertura, string chiusura)
        {
            Nome = nome;
            Indirizzo = indirizzo;
            OrarioApertura = apertura;
            OrarioChiusura = chiusura;
            elencoLibri = new List<Libro>();
        }

        // Aggiunta libro
        public void AggiungiLibro(Libro l)
        {
            if (elencoLibri.Count < 1000)
                elencoLibri.Add(l);
            else
                Console.WriteLine("Biblioteca piena!");
        }

        // Ricerca per titolo
        public Libro CercaPerTitolo(string titolo)
        {
            return elencoLibri.Find(l => l.Titolo.Equals(titolo, StringComparison.OrdinalIgnoreCase));
        }

        // Ricerca per autore
        public List<Libro> CercaPerAutore(string autore)
        {
            return elencoLibri.Where(l => l.Autore.Equals(autore, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        // Numero totale libri
        public int NumeroLibri()
        {
            return elencoLibri.Count;
        }
    }
}
