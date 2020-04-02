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

        private const int _ = 0, O = -1, S = 1;

        private (int isPlayerOneSos, int letter, int isPlayerTwoSos)[,] _board =
            new (int isPlayerOneSos, int letter, int isPlayerTwoSos)[Size, Size];

        private List<int> _winnersByRound = new List<int>();

        public Game(int idGameSize = 0)
        {
            //_board[1, 2] = (1, -1, 0);
            //_board[1, 1] = (1, 1, 0);
            //_board[1, 3] = (1, 1, 1);
            //_board[3, 3] = (0, 1, 1);
            //_board[2, 3] = (0, -1, 1);
            //_board[3, 1] = (0, 1, 0);

            CurPlayer = PlayerOne;
        }

        public Game(IEnumerable<(int isPlayerOneSos, int letter, int isPlayerTwoSos)> board, int curPlayer, int idGameSize = 0, int numRound = 0, int nbGameRounds = 3)
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
            NumRound = numRound;
            NbGameRounds = nbGameRounds;
        }

        public int Play(Turn pos)
        {
            if (_board[pos.Column, pos.Row].letter != Empty)
            {
                throw new InvalidOperationException("Already played here");
            }
            var score = LookAround(CurPlayer.Value, pos);
            FindNextPlayer(CurPlayer.Value, score);
            return score;
        }

        public (int isPlayerOneSos, int letter, int isPlayerTwoSos) GetTile(Turn pos) =>
            (
                _board[pos.Column, pos.Row].isPlayerOneSos,
                _board[pos.Column, pos.Row].letter,
                _board[pos.Column, pos.Row].isPlayerTwoSos
            );
        public (int isPlayerOneSos, int letter, int isPlayerTwoSos) GetTile(int col, int row) =>
            (
                _board[col, row].isPlayerOneSos,
                _board[col, row].letter,
                _board[col, row].isPlayerTwoSos
            );

        private void SetTile(Turn turn, (int, int, int) value)
        {
            _board[turn.Column, turn.Row] = value;
        }
        /// <summary>
        /// Gets all the board squares starting from left to right and then from top to bottom
        /// </summary>
        public IEnumerable<(int isPlayerOneSos, int letter, int isPlayerTwoSos)> Tiles
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

        public IEnumerable<int> WinnersByRound => _winnersByRound;
        public int? CurPlayer { get; private set; } = PlayerOne;
        public int? Winner { get; private set; } = null;
        public int CanIplay => Tiles.Count(c => c.letter == 0);
        public int NbGameRounds { get; private set; } = 3;
        public int NumRound { get; private set; } = 0;
        public int NbTokenMax { get; private set; } = 5;

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

        private void TransformSosLetterS(int player, Turn posTemp, Turn pos, int dx, int dy)
        {

            if (player == PlayerOne)
            {
                for (int i = 0; i < 2; i++)
                {
                    _board[posTemp.Column, posTemp.Row].isPlayerOneSos = 1;
                    posTemp.Move(dx, dy);
                }
                SetTile(posTemp, (IsPlayerSos, pos.Letter, Empty));
            }
            else
            {
                for (int i = 0; i < 2; i++)
                {
                    _board[posTemp.Column, posTemp.Row].isPlayerTwoSos = 1;
                    posTemp.Move(dx, dy);
                }
                SetTile(posTemp, (Empty, pos.Letter, IsPlayerSos));
            }
        }
        private void TransformSosLetterO(int player, Turn posTemp, Turn pos, int dx, int dy)
        {
            for (int i = 0; i < 3; i++)
            {
                if (player == PlayerOne)
                {
                    if (GetTile(posTemp).letter == -pos.Letter)
                    {
                        _board[posTemp.Column, posTemp.Row].isPlayerOneSos = IsPlayerSos;
                    }
                    else
                    {
                        SetTile(posTemp, (IsPlayerSos, pos.Letter, Empty));
                    }
                }
                else if (player == PlayerTwo)
                {
                    if (GetTile(posTemp).letter == -pos.Letter)
                    {
                        _board[posTemp.Column, posTemp.Row].isPlayerTwoSos = IsPlayerSos;
                    }
                    else
                    {
                        SetTile(posTemp, (Empty, pos.Letter, IsPlayerSos));
                    }
                }
                posTemp.Move(dx, dy);
            }
        }

        private int LookAround(int player, Turn pos)
        {
            var delta = new (int dx, int dy)[]{
                ( -1, -1 ), (  0, -1 ), (  1, -1 ),
                ( -1,  0 ),             (  1,  0 ),
                ( -1,  1 ), (  0,  1 ), (  1,  1 )
            };

            var score = 0;

            //     //  0    1    2    3    4  
            //        ___, ___, ___, ___, ___, // 0
            //        ___, xS_, xO_, xS_, ___, // 1
            //        ___, ___, ___, ___, ___, // 2
            //        ___, _Sx, _Ox, _Sx, ___, // 3
            //        ___, ___, ___, ___, ___, // 4

            if (pos.Letter == LetterO)
            {
                for (var dir = 0; dir < delta.Length / 2; dir++)
                {
                    var posTemp = pos;
                    var isMove = posTemp.Move(delta[dir].dx, delta[dir].dy);
                    var firstLetter = GetTile(posTemp).letter;
                    var isMoveReverse = posTemp.Move(2 * delta[delta.Length - 1 - dir].dx, 2 * delta[delta.Length - 1 - dir].dy);

                    if ((isMove && firstLetter == LetterS)
                    && (isMoveReverse && GetTile(posTemp).letter == LetterS))
                    {
                        TransformSosLetterO(player, posTemp, pos, delta[dir].dx, delta[dir].dy);
                        score += player;
                        Console.WriteLine("SOS");
                    };
                }
            }

            else if (pos.Letter == LetterS)
            {
                for (var dir = 0; dir < delta.Length; dir++)
                {
                    var posTemp = pos;

                    if ((posTemp.Move(delta[dir].dx, delta[dir].dy) && GetTile(posTemp).letter == LetterO)
                        && (posTemp.Move(delta[dir].dx, delta[dir].dy) && GetTile(posTemp).letter == LetterS))
                    {
                        TransformSosLetterS(player, posTemp, pos, delta[delta.Length - 1 - dir].dx, delta[delta.Length - 1 - dir].dy);
                        score += player;
                    }                    
                }
            }
            if (score == 0)
            {
                SetTile(pos, (Empty, pos.Letter, Empty));
            }
            return score;
        }

    }
}
