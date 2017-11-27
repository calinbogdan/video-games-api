using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoGamesApi.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string HeadquartersLocation { get; set; }
        public DateTime FoundedOn { get; set; }
        public string WebsiteURL { get; set; }

        public List<VideoGame> Games { get; set; }
    }
}
