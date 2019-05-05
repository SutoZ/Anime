using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimeAddicts.Models
{
    public static class DbInitializer
    {
        public static void Seed(AnimeContext animeContext)
        {
            if (!animeContext.Animes.Any())
            {
                animeContext.AddRange(
                    new Anime
                    {
                        Title = "Kiss Dekiru Gyoza x Mameshiba Movie",
                        Duration = "90 perc",
                        Genres = "anime, special",
                        Premiere = "anime",
                        Date = new DateTime(2008, 07, 01),
                        ID = Guid.NewGuid(),
                        ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ut sodales nunc. Integer fermentum at dolor sed efficitur. Aenean volutpat auctor tincidunt. Suspendisse interdum pellentesque congue. In interdum mauris vitae."
                    },
                    new Anime
                    {
                        Title = ".hack//G.U. Trilogy Special: Parody Mode",
                        Duration = "90 perc",
                        Genres = "anime, special",
                        Premiere = "anime",
                        Date = new DateTime(2008, 07, 01),
                        ID = Guid.NewGuid(),
                        ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ut sodales nunc. Integer fermentum at dolor sed efficitur. Aenean volutpat auctor tincidunt. Suspendisse interdum pellentesque congue. In interdum mauris vitae."
                    },
                    new Anime
                    {
                        Title = ".hack//G.U. Returner",
                        Duration = "60 perc",
                        Genres = "anime, OVA",
                        Premiere = "anime",
                        Date = new DateTime(2006, 07, 01),
                        ID = Guid.NewGuid(),
                        ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ut sodales nunc. Integer fermentum at dolor sed efficitur. Aenean volutpat auctor tincidunt. Suspendisse interdum pellentesque congue. In interdum mauris vitae."
                    }
                    );

                animeContext.SaveChanges();
            }
        }
    }
}
