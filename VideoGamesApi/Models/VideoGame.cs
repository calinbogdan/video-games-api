using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoGamesApi.Models
{
    public class VideoGame
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime PublishedOn { get; set; }
        public Developer Developer { get; set; }
        public Publisher Publisher { get; set; }
        public Genre Genre { get; set; }

        public IEnumerable<Platform> Platforms { get; set; }
    }
}
