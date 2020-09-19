using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sos;
using SosAPI.Models;

namespace MorpionAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {

        private IGameRepository _gameRepo;

        public GamesController(IGameRepository gameRepo)
        {
            _gameRepo = gameRepo;
        }



        // GET api/values
        [HttpGet]
        public Dictionary<string, Game> Get() // ActionResult
        {
            return _gameRepo.AllGames;
        }

        // GET games/MaPartie 
        [HttpGet("{key}")]
        public Game Get(string key)
        {
            return _gameRepo.FindByKey(key);
        }

        // POST games/MaPartie/B2S
        [HttpPatch("{key}/{positionAndLetter}")]
        public ActionResult<Game> Patch(string key, string positionAndLetter)
        {
            var game = _gameRepo.FindByKey(key);
            if (game == null) return NotFound("Jeu pas trouvé");

            try
            {
                var position = Turn.Parse(positionAndLetter);
                game.Play(position);
                return game;
            }
            catch (InvalidOperationException e)
            {
                return BadRequest(e.Message);
            }
            catch (ArgumentException e)
            {
                return BadRequest(e.Message);
            }

        }

        [HttpPatch("{key}")]
        public ActionResult<Game> PatchFromBody(string key, [FromBody] Turn positionAndLetter)
        {
            var game = _gameRepo.FindByKey(key);
            if (game == null) return NotFound("Jeu pas trouvé");

            try
            {
                //var position = Turn.Parse(positionAndLetter);
                game.Play(positionAndLetter); 
                return game;
            }
            catch (InvalidOperationException e)
            {
                return BadRequest(e.Message);
            }
            catch (ArgumentException e)
            {
                return BadRequest(e.Message);
            }
        }

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
