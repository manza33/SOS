using System;
using System.Collections.Generic;
using System.Text;

namespace Sos
{
    public struct Turn
    {

        private static int _maxSize = Game.Size;

        private static void CheckColumnRow(int colrow)
        {
            if (colrow < 0 || _maxSize < colrow)
            {
                throw new ArgumentOutOfRangeException("Column/Row out of bounds");
            }
        }

        public Turn(int column, int row, int letter)
        {
            CheckColumnRow(column);
            CheckColumnRow(row);
            Column = column;
            Row = row;
            Letter = letter;
        }

        public static Turn Parse(string textWithPositionAndLetter)
        {
            if (textWithPositionAndLetter == null)
            {
                throw new ArgumentNullException("Text to parse cannot be null");
            }
            if (textWithPositionAndLetter.Length != 3)
            {
                throw new ArgumentException("Invalid position format");
            }
            if (textWithPositionAndLetter[0] < 'A' || 'Z' < textWithPositionAndLetter[0])
            {
                throw new ArgumentException("Column must be a letter");
            }
            if (textWithPositionAndLetter[2] != 'O' && textWithPositionAndLetter[2] != 'S')
            {
                throw new ArgumentException("Letter must be O or S");
            }
            var col = textWithPositionAndLetter[0] - 'A';
            var row = textWithPositionAndLetter[1] - '1';
            var letter = textWithPositionAndLetter[2] == 'S' ? 1 : -1 ;

            return new Turn(col, row, letter);
        }

        public bool Next()
        {
            if (Column == _maxSize - 1)
            {
                if (Row == _maxSize - 1)
                {
                    return false;
                }
                Row++;
                Column = -1;
            }
            Column++;
            return true;
        }

        public int Column { get; private set; }
        public int Row { get; private set; }
        public override string ToString() => $"{GetColumnName(Column)}{GetRowName(Row)}";
        public int Letter { get; set; }

        public static string GetColumnName(int col)
        {
            CheckColumnRow(col);
            return $"{(char)('A' + col)}";
        }

        public static string GetRowName(int row)
        {
            CheckColumnRow(row);
            return $"{ row + 1 }";
        }

        public static string GetLetter(int letter)
        {
            if(letter == 1)
            {
                return "S";
            }
            else if (letter == -1)
            {
                return "O";
            }
            return " ";
        }

        public bool Move(int dx, int dy)
        {
            var newCol = Column + dx;
            var newRow = Row + dy;
            var valid = 0 <= newCol && newCol < _maxSize
                     && 0 <= newRow && newRow < _maxSize;

            if (valid)
            {
                Column = newCol;
                Row = newRow;
            }

            return valid;
        }

    }
}
