using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaProvaVerifica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creazione Biblioteca
            Biblioteca miaBiblioteca = new Biblioteca("Centrale", "Via Roma 1", "08:00", "18:00");

            // Test Aggiunta
            Libro l1 = new Libro("Dante Alighieri", "Divina Commedia", 1320, "Zanichelli", 500);
            Libro l2 = new Libro("Italo Svevo", "La Coscienza di Zeno", 1923, "Einaudi", 150);

            miaBiblioteca.AggiungiLibro(l1);
            miaBiblioteca.AggiungiLibro(l2);

            Console.WriteLine($"Libri in biblioteca: {miaBiblioteca.NumeroLibri()}");

            // Test Ricerca Titolo
            Console.WriteLine("\nRicerca 'Divina Commedia':");
            var trovato = miaBiblioteca.CercaPerTitolo("Divina Commedia");
            Console.WriteLine(trovato != null ? trovato.ToString() : "Non trovato");

            // Test Reading Time
            Console.WriteLine($"Tempo lettura Svevo: {l2.ReadingTime()}");

            Console.WriteLine("\nPremi un tasto per uscire...");
            Console.ReadKey();
        }
    }
    }
}
