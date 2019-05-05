using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimeAddicts.Models
{
    public interface IAnimeRepository
    {
        IEnumerable<Anime> GetAllAnimes();
    }
}
