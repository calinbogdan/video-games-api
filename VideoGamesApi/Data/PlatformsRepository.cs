using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoGamesApi.Models;

namespace VideoGamesApi.Data
{
    public class PlatformsRepository : IBaseRepository<Platform>
    {
        private readonly VideoGamesContext _videoGamesContext;

        public PlatformsRepository(VideoGamesContext videoGamesContext)
        {
            _videoGamesContext = videoGamesContext;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public void Add(Platform item)
        {
            _videoGamesContext.Add(item);
            _videoGamesContext.SaveChanges();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            var platform = Get(id);

            if (platform == null)
                throw new Exception();

            _videoGamesContext.Remove(platform);
            _videoGamesContext.SaveChanges();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Platform> Get()
        {
            return _videoGamesContext.Platforms.ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Platform Get(int id)
        {
            return _videoGamesContext.Platforms.Where(p => p.Id == id).SingleOrDefault();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public void Update(Platform item)
        {
            _videoGamesContext.Update(item);
            _videoGamesContext.SaveChanges();
        }
    }
}
