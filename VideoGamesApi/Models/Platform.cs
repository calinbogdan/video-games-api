﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoGamesApi.Models
{
    public class Platform
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<VideoGame> Games { get; set; }
    }
}
