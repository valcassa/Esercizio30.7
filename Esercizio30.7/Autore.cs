using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio30._7.Entità
{
    class Autore : Podcast
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string AnnoDiNascita { get; set; }


        public Autore(string titolo, string autore, string desc, List<Episodi> episodi, string nome, string cognome, string annonascita)
        : base(titolo, autore, desc, episodi)
        {
            Nome = nome;
            Cognome = cognome;
            AnnoDiNascita = annonascita;
        }
    }

}