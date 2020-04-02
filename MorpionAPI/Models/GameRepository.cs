using Sos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SosAPI.Models
{
    public class GameRepository : IGameRepository
    {
        private Dictionary< string, Game> _repo = new Dictionary<string, Game>();
        public Dictionary<string, Game> AllGames => _repo;

        public Game FindByKey( string key)
        {
            Game result = null;

            if (_repo.ContainsKey(key))
            {
                result = _repo[key];
            }
            else
            {
                result = new Game();
                _repo[key] = result;
            }
            return result;
        }

    }
}
