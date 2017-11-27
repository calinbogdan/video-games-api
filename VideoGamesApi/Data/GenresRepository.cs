using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoGamesApi.Models;

namespace VideoGamesApi.Data
{
    public class GenresRepository : IBaseRepository<Genre>
    {
        private readonly VideoGamesContext _videoGamesContext;
        
        public GenresRepository(VideoGamesContext videoGamesContext)
        {
            _videoGamesContext = videoGamesContext;
        }

        public void Add(Genre item)
        {
            _videoGamesContext.Add(item);
            _videoGamesContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var genre = Get(id);

            if (genre == null)
                throw new Exception(); // GenreNotFoundException

            _videoGamesContext.Remove(genre);
            _videoGamesContext.SaveChanges();
        }

        public IEnumerable<Genre> Get()
        {
            return _videoGamesContext.Genres.ToList();
        }

        public Genre Get(int id)
        {
            return _videoGamesContext.Genres.Where(g => g.Id == id).SingleOrDefault();
        }

        public void Update(Genre item)
        {
            _videoGamesContext.Update(item);
            _videoGamesContext.SaveChanges();
        }
    }
}
