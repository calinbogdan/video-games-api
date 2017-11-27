using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoGamesApi.Models;

namespace VideoGamesApi.Data
{
    public class VideoGamesRepository : IBaseRepository<VideoGame>
    {
        private readonly VideoGamesContext _videoGamesContext;

        public VideoGamesRepository(VideoGamesContext videoGamesContext)
        {
            _videoGamesContext = videoGamesContext;
        }

        /// <summary>
        /// Creates a new video game in the database.
        /// </summary>
        /// <param name="item">The item to be created.</param>
        public void Add(VideoGame item)
        {
            _videoGamesContext.Add(item);
            _videoGamesContext.SaveChanges();
        }

        /// <summary>
        /// Deletes the VideoGame object at the given id.
        /// </summary>
        /// <param name="id">The id of the video game you want to delete.</param>
        public void Delete(int id)
        {
            var videoGame = Get(id);

            if (videoGame == null)
            {
                throw new Exception();
            }

            _videoGamesContext.Remove(videoGame);
        }

        /// <summary>
        /// Gets all the video games in the database.
        /// </summary>
        /// <returns>Returns all the current video games in the database.</returns>
        public IEnumerable<VideoGame> Get()
        {
            return _videoGamesContext.VideoGames.ToList();
        }

        /// <summary>
        /// Returns a single VideoGame object from the database if it is found at the given id.
        /// </summary>
        /// <param name="id">The id of the video game to look for.</param>
        /// <returns>Returns the VideoGame object or null if there's no record with the given id.</returns>
        public VideoGame Get(int id)
        {
            return _videoGamesContext.VideoGames.Where(vg => vg.Id == id).SingleOrDefault();
        }

        /// <summary>
        /// Updates the item at the current id with new values.
        /// </summary>
        /// <param name="item">The item to be updated with new values.</param>
        public void Update(VideoGame item)
        {
            _videoGamesContext.Update(item);
            _videoGamesContext.SaveChanges();
        }
    }
}
