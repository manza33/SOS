using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SosForms.Models
{
    class GameOnline
    {
        public int? CurPlayer { get; set; }
        public int? Winner { get; set; }
        public List<int> Tiles { get; set; }
    }
}
