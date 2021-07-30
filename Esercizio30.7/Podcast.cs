using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio30._7
{
    public class Podcast
    {

        public string Titolo { get; set; }
        public string Autore { get; set; }
        public string Descrizione { get; set; }

        public double Durata { get; set; }



        public Podcast(string titolo, string autore, string desc, double d)
        {
             Titolo = titolo;
             Autore = autore;
             Descrizione = desc;            
             Durata = d;

         }

        public enum Episodi
        {
            Episodio1,
            Episodio2,
            Episodio3,
            Episodio4,


        }


    }
}
    