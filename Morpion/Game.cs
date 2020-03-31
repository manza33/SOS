using System;
using System.Collections.Generic;
using System.Linq;

namespace Sos
{
    public class Game
    {
        public const int Size = 5;
        public const int Empty = 0;
        public const char LetterS = 'S';
        public const char LetterO = 'O';
        public const int PlayerOne = 1;
        public const int PlayerTwo = -1;

        private (int isPlayerOneSos, int nbTokenMax, int isPlayerTwoSos)[,] _board = 
            new (int isPlayerOneSos, int nbTokenMax, int isPlayerTwoSos)[Size, Size];

        //private (int size,int nbTokenMax)[] _gameSize = new(int size, int nbTokenMax)[]{
        //        ( 3, 3 ), ( 6, 5 ), ( 8, 5 )
        //    }; 

        private List<int> _winnersByRound = new List<int>();

        public Game(int idGameSize = 0)
        {
            //Size = _gameSize[idGameSize].size;
            //NbTokenMax = _gameSize[idGameSize].nbTokenMax;
            //_board = new int[Size, Size];
            CurPlayer = PlayerOne;
        }

        public Game(IEnumerable<(int isPlayerOneSos, int nbTokenMax, int isPlayerTwoSos)> board, int curPlayer, int idGameSize = 0, int numRound = 0, int nbGameRounds = 3)
        {

            var turn = new Turn();
            //Size = _gameSize[idGameSize].size;
            //NbTokenMax = _gameSize[idGameSize].nbTokenMax;
            //_board = new int[Size, Size];

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
            if (_board[pos.Column, pos.Row].nbTokenMax != Empty)
            {
                throw new InvalidOperationException("Already played here");
            }
            var score = LookAround(CurPlayer.Value, pos, true);
            FindNextPlayer(CurPlayer.Value, score);
            return score;
        }

        //public void resetGame(int winner)
        //{
        //   if(winner != 0)
        //    {
        //        NumRound++;
        //    }
        //    _board = new int[Size, Size];
        //    _winnersByRound.Add(Winner.Value);
        //    CurPlayer = -Winner.Value;
        //    Winner = null;
        //}

        public int GetTile(Turn pos) => _board[pos.Column, pos.Row].nbTokenMax;
        public int GetTile(int col, int row) => _board[col, row].nbTokenMax;
        private void SetTile(Turn turn, int value)
        {
            _board[turn.Column, turn.Row].nbTokenMax = value;
        }
        /// <summary>
        /// Gets all the board squares starting from left to right and then from top to bottom
        /// </summary>
        public IEnumerable<(int isPlayerOneSos, int nbTokenMax, int isPlayerTwoSos)> Tiles
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
        public int CanIplay => Tiles.Count(c => c.nbTokenMax == 0);
        public int NbGameRounds { get; private set; } = 3;
        public int NumRound { get; private set; } = 0;
        public int NbTokenMax { get; private set; } = 5;

        // Private
        private void FindNextPlayer(int tryPlayer, int score)
        {
            if (CanIplay > 0 && score < NbTokenMax) {
                CurPlayer = -tryPlayer; 
            }
            else
            {
                Winner = CanIplay == 0 ? 0 : CurPlayer;
                CurPlayer = null;
            }
        }

        private int LookAround(int player, Turn pos, bool apply)
        {
            var delta = new (int dx, int dy)[]{
                ( -1, -1 ), (  0, -1 ), (  1, -1 ),
                ( -1,  0 ),             (  1,  0 ),
                ( -1,  1 ), (  0,  1 ), (  1,  1 )
            };

            var color = player;
            var listScores = new List<int>();
            

            for (var dir = 0; dir < delta.Length; dir++)
            {
                listScores.Add(BrowseTiles(pos, delta[dir].dx, delta[dir].dy, color, apply));
            }
            if (apply)
            {
                SetTile(pos, pos.Letter);
            }
            return listScores.Max();
        }

        private int BrowseTiles(Turn pos, int dx, int dy, int color, bool apply, int distance = 1)
        {
            //    0  1  2  
            // 0  O, X, _, 
            // 1  O, X, _, 
            // 2  _, _, _, 
            bool isMove = true;

            if (!pos.Move(dx, dy) || GetTile(pos) == Empty)
            {
                return 0;
            }

            while (GetTile(pos) == color && isMove)
            {
                distance++;
                if (!pos.Move(dx, dy)) { 
                    isMove = false; 
                }
                Console.WriteLine($"Distance : {distance}");
            }
            return distance;
        }

    }
}
