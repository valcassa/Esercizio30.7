using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio30._7
{
    public class Canzoni
    {
        public string Titolo { get; set; }
        public string Autore { get; set; }

        public string[] Genere { get; set; }


        public Canzoni(string titolo, string autore, string[] genere)
        {
            Titolo = titolo;
            Autore = autore;
            string [] Genere = new string[] { } ;
         }

         
    }
}

