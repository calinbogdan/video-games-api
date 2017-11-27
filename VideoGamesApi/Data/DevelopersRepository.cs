using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoGamesApi.Models;

namespace VideoGamesApi.Data
{
    public class DevelopersRepository : IBaseRepository<Developer>
    {
        private readonly VideoGamesContext _videoGamesContext;

        public DevelopersRepository(VideoGamesContext videoGamesContext)
        {
            _videoGamesContext = videoGamesContext;
        }

        public void Add(Developer item)
        {
            _videoGamesContext.Add(item);
            _videoGamesContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var developer = Get(id);

            if (developer == null)
            {
                throw new Exception(); // DeveloperNotFoundException
            }

            _videoGamesContext.Remove(developer);
            _videoGamesContext.SaveChanges();
        }

        public IEnumerable<Developer> Get()
        {
            return _videoGamesContext.Developers.ToList();
        }

        public Developer Get(int id)
        {
            return _videoGamesContext.Developers.Where(d => d.Id == id).SingleOrDefault();
        }

        public void Update(Developer item)
        {
            _videoGamesContext.Update(item);
            _videoGamesContext.SaveChanges();
        }
    }
}
