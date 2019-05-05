using AnimeAddicts.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimeAddicts.Controllers
{
    public class AnimeController : Controller
    {
        private readonly IAnimeRepository animeRepository;

        public AnimeController(IAnimeRepository animeRepository)
        {
            this.animeRepository = animeRepository;
        }

    }
}
