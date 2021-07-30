using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio30._7
{
    public class Episodi : Podcast
    { 
        public string TitoloPod { get; set; }
        public bool isPlayed { get; set; }

        public Episodi(string titolo, string autore, string desc, double dur, string titoloPod,  bool isplayed)
        : base(titolo, autore, desc, dur)
        {
            TitoloPod = titoloPod;
            isPlayed = isplayed;
        }
    }
}
