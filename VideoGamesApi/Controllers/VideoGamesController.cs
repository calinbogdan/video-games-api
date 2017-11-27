using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VideoGamesApi.Models;
using VideoGamesApi.Data;

namespace VideoGamesApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class VideoGamesController : Controller
    {
        private readonly IBaseRepository<VideoGame> _videoGamesRepository;

        public VideoGamesController(IBaseRepository<VideoGame> videoGamesRepository)
        {
            _videoGamesRepository = videoGamesRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var videoGames = _videoGamesRepository.Get();
            return Ok(videoGames);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var videoGame = _videoGamesRepository.Get(id);

            if (videoGame == null)
                return NotFound();

            return Ok(videoGame);
        }

        [HttpPost]
        public IActionResult Post([FromBody]VideoGame videoGame)
        {
            _videoGamesRepository.Add(videoGame);
            return Created($"/api/videogames/{videoGame.Id}", videoGame);
        }

        [HttpPut]
        public IActionResult Put(VideoGame videoGame)
        {
            _videoGamesRepository.Update(videoGame);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _videoGamesRepository.Delete(id);
            return NoContent();
        }
    }
}