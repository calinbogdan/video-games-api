using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoGamesApi.Models;

namespace VideoGamesApi.Data
{
    public class PublishersRepository : IBaseRepository<Publisher>
    {
        private readonly VideoGamesContext _videoGamesContext;

        public PublishersRepository(VideoGamesContext videoGamesContext)
        {
            _videoGamesContext = videoGamesContext;
        }

        public void Add(Publisher item)
        {
            _videoGamesContext.Add(item);
            _videoGamesContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var publisher = Get(id);

            if (publisher == null)
                throw new Exception(); // PublisherNotFoundException

            _videoGamesContext.Remove(publisher);
            _videoGamesContext.SaveChanges();
        }

        public IEnumerable<Publisher> Get()
        {
            return _videoGamesContext.Publishers.ToList();
        }

        public Publisher Get(int id)
        {
            return _videoGamesContext.Publishers.Where(p => p.Id == id).SingleOrDefault();
        }

        public void Update(Publisher item)
        {
            _videoGamesContext.Update(item);
            _videoGamesContext.SaveChanges();
        }
    }
}
