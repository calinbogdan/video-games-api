using System.Collections.Generic;

namespace VideoGamesApi.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<VideoGame> Games { get; set; }
    }
}