
using Esercizio30._7.Rep;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Esercizio30._7
{
    public class PodcastRep : IRep<Podcast>
    {

        public static List<Podcast> listapodcast = new List<Podcast>();


        public List<Podcast> Fetch()
        {
            listapodcast.Add(new Podcast("Musica '90", "Abc", "Cdfg", 20.00));
            listapodcast.Add(new Podcast("Musica 2000", "bc", "Cffg", 10.00));

            return listapodcast;

        }

        public static StampaEpisodi()
        {
            Console.WriteLine("Inserisci Episodio");
            string ListaPodcast = Console.ReadLine();
            bool ifExist = listapodcast.Any(pr => pr.Titolo == ListaPodcast);

            if (ifExist) {
                foreach (Podcast eppodcast in Enum.GetValues(EpisodiRep))
                {
                    var ep = listapodcast;
                }

                return listapodcast;
            }


            public List<Podcast> GetByDurata()
            {
                double podcastdur;
                Console.WriteLine("Inserisci durata");
                double.TryParse(Console.ReadLine(), out double durata);


                bool ifExist = listapodcast.Any(Podcast.Durata == durata, out podcastdur);

                return podcastdur;
            }
        }
    }
}