using Esercizio30._7.Rep;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Esercizio30._7
{   
        public class CanzoniRep : IRep<Canzoni>

    {
        public static List<Canzoni> listacanzoni = new List<Canzoni>();

        public List<Canzoni> Fetch()
        {

            listacanzoni.Add(new Canzoni("The Show Must Go On", "Queen", "Rock"));
            listacanzoni.Add(new Canzoni("Butter", "BTS", "Pop"));

            return listacanzoni;
        //Nella logica che ho pensato, volevo creare un array di Genere con tutti i Generi.

        }

        public List<Canzoni> FindCanzone()
        {
            string find;

            Console.WriteLine("Inserisci genere");
            find = Console.ReadLine();
            CanzoniRep cr = new CanzoniRep();
            return find = Canzoni.Where(find == cr.Genere).ToList(cr.Genere);

         }
        }

       
    }
