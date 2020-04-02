using Sos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SosAPI.Models
{
    public interface IGameRepository
    {
        Dictionary<string, Game> AllGames { get; }

        Game FindByKey(string key);
    }
}
