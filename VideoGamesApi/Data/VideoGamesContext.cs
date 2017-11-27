using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoGamesApi.Models;

namespace VideoGamesApi.Data
{
    public class VideoGamesContext : DbContext
    {
        public VideoGamesContext(DbContextOptions<VideoGamesContext> options) : base(options) { }
        
        public DbSet<VideoGame> VideoGames { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Developer> Developers { get; set; }
    }
}
