using System;

namespace AnimeAddicts.Models
{
    public class Anime
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string Genres { get; set; }
        public string Duration { get; set; }
        public DateTime? Date { get; set; }
        public string Premiere { get; set; }
        public string URLs { get; set; }
        public string ShortDescription { get; set; }
        public Anime() { }
    }
}
