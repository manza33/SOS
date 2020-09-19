using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SosForms.Models
{
    class PositionAndLetter
    {
        public PositionAndLetter(int column, int row, int letter)
        {
            Column = column;
            Row = row;
            Letter = letter;
        }

        public int Column { get; set; }
        public int Row { get; set; }
        public int Letter { get; set; }
    }
}
