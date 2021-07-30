using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio30._7
{
    class Start
    {

        public static CanzoniRep cr = new CanzoniRep();
        public static PodcastRep pr = new PodcastRep();


        public static void Menu()
        {


            Console.WriteLine("*** Programma eseguito ***");
            Console.WriteLine("Scegli tra le seguenti opzioni:");
            Console.WriteLine("1- Visualizza tutte le canzoni");
            Console.WriteLine("2- Visualizza tutti i podcast");
            Console.WriteLine("3- Visualizza canzoni per genere");
            Console.WriteLine("4- Visualizza gli episodi di un podcast");
            Console.WriteLine("5- Visualizza gli episodi di un podcast per durata");

            while (true)
            {
                int scelta;
                Console.WriteLine("Seleziona un numero da 1 a 5.");

                while (int.TryParse(Console.ReadLine(), out scelta)) ;



                switch (scelta)
                {
                    case 1:
                        List<Canzoni> listacanzoni = cr.Fetch();

                        break;
                    case 2:
                        List<Podcast> listapodcast = pr.Fetch();
                        break;
                    case 3:
                        cr.FindCanzone();
                        break;
                    case 4:
                         List<Podcast> sceglipodcast = pr.StampaEpisodi();

                        break;

                    case 5:
                        Console.WriteLine("Scegli un podcast");
                        List<Podcast> scelgipodcastd = Console.ReadLine(Podcast.Durata);
                        List<Podcast> sceglipodcastd = PodcastRep.GetByDurata();

                        break;

                    default:
                        Console.WriteLine("Inserisci scelta valida");
                        break;
                    case 0:
                        break;
                }

            }
            }
        }    
    } 
}
