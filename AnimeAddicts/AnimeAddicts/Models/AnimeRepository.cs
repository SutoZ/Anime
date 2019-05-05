using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimeAddicts.Models
{
    public class AnimeRepository : IAnimeRepository
    {
        private readonly AnimeContext animeContext;

        public AnimeRepository(AnimeContext animeContext)
        {
            this.animeContext = animeContext;
        }

        public IEnumerable<Anime> GetAllAnimes()
        {
            return animeContext.Animes
                .OrderBy(x => x.Title)
                .ToList();
        }
    }
}
