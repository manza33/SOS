using System;
using System.Collections.Generic;
using System.Linq;

namespace Sos
{
    public class Game
    {
        public const int Size = 5;
        public const int Empty = 0;
        public const int LetterS = 1;
        public const int LetterO = -1;
        public const int PlayerOne = 1;
        public const int PlayerTwo = -1;
        public const int IsPlayerSos = 1;

        private Tile[,] _board = new Tile[Size, Size];

        public Game()
        {
            var pos = new Turn();
            for (int i = 0; i < Size * Size; i++)
            {
                var tile = Tile.Parse();

                SetTile(pos, tile);
                if (!pos.Next())
                {
                    break;
                }

            }
            CurPlayer = PlayerOne;
        }

        public Game(IEnumerable<Tile> board, int curPlayer)
        {
            var turn = new Turn();

            foreach (var tile in board)
            {
                SetTile(turn, tile);
                if (!turn.Next())
                {
                    break;
                }
            }
            CurPlayer = curPlayer;
        }

        public int Play(Turn pos)
        {
            if (_board[pos.Column, pos.Row].Letter != Empty)
            {
                throw new InvalidOperationException("Already played here");
            }
            var score = LookAround(CurPlayer.Value, pos);
            FindNextPlayer(CurPlayer.Value, score);
            return score;
        }

        public Tile GetTile(Turn pos) => _board[pos.Column, pos.Row];

        public Tile GetTile(int col, int row) => _board[col, row];

        private void SetTile(Turn pos, Tile tile)
        {
            _board[pos.Column, pos.Row] = tile;
        }
        /// <summary>
        /// Gets all the board squares starting from left to right and then from top to bottom
        /// </summary>
        public IEnumerable<Tile> Tiles
        {
            get
            {
                // return _board; Impossible car int [,] n'est pas IEnumerable<int>
                for (var row = 0; row < Size; row++)
                {
                    for (var col = 0; col < Size; col++)
                    {
                        yield return _board[col, row]; // yield retourne le 1er, puis le second (n'interrompt pas le foreach)
                    }
                }
            }
        }

        public int? CurPlayer { get; private set; } = PlayerOne;
        public int? Winner { get; private set; } = null;
        public int CanIplay => Tiles.Count(c => c.Letter == 0);

        // Private
        private void FindNextPlayer(int tryPlayer, int score)
        {
            if (CanIplay > 0)
            {
                CurPlayer = -tryPlayer;
            }
            else
            {
                Winner = score > 0 ? PlayerOne : PlayerTwo;
                CurPlayer = null;
            }
        }

        private void TransformSosLetter(int player, Turn pos, int dx, int dy)
        {
            for (int i = 0; i < 3; i++)
            {
                GetTile(pos).AddSosPlayer(player);
                pos.Move(dx, dy);
            }
        }

        private int VerifAroundLetterO(Tile transformTile, int player, Turn pos, (int dx, int dy)[] delta)
        {
            var score = 0;

            for (var dir = 0; dir < delta.Length / 2; dir++)
            {
                var posTemp = pos;
                var isMove = posTemp.Move(delta[dir].dx, delta[dir].dy);
                var firstLetter = GetTile(posTemp).Letter;
                var isMoveReverse = posTemp.Move(2 * delta[delta.Length - 1 - dir].dx, 2 * delta[delta.Length - 1 - dir].dy);

                if ((isMove && firstLetter == LetterS)
                && (isMoveReverse && GetTile(posTemp).Letter == LetterS))
                {
                    TransformSosLetter(player, posTemp, delta[dir].dx, delta[dir].dy);

                    score += player;
                    Console.WriteLine("SOS");
                };
            }
            return score;
        }

        private int VerifAroundLetterS(Tile transformTile, int player, Turn pos, (int dx, int dy)[] delta)
        {
            var score = 0;

            for (var dir = 0; dir < delta.Length; dir++)
            {
                var posTemp = pos;
                if ((posTemp.Move(delta[dir].dx, delta[dir].dy) && GetTile(posTemp).Letter == LetterO)
                    && (posTemp.Move(delta[dir].dx, delta[dir].dy) && GetTile(posTemp).Letter == LetterS))
                {
                    TransformSosLetter(player, posTemp, delta[delta.Length - 1 - dir].dx, delta[delta.Length - 1 - dir].dy);
                    score += player;
                }
            }

            return score;
        }

        private int LookAround(int player, Turn pos)
        {
            //var score = 0;
            var delta = new (int dx, int dy)[]{
                ( -1, -1 ), (  0, -1 ), (  1, -1 ),
                ( -1,  0 ),             (  1,  0 ),
                ( -1,  1 ), (  0,  1 ), (  1,  1 )
            };
            
            var transformTile = GetTile(pos);
            transformTile.AddLetter(pos.Letter);

            var score = pos.Letter == LetterO ?
                VerifAroundLetterO(transformTile, player, pos, delta):
                VerifAroundLetterS(transformTile, player, pos, delta);

            SetTile(pos, transformTile);

            return score;
        }

    }
}
