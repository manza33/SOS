using System;
using System.Linq;
using Sos;

namespace SosClient
{
    class Program
    {

        private static void DrawLine(int numLine, int maxSize)
        {
            var line = "";
            if (numLine == 0)
            {
                line = "┌───";
                for (int j = 0; j < maxSize - 1; j++)
                {
                    line += "┬───";
                }
                line += "┐";
            }
            else if (numLine == maxSize)
            {
                line = "└───";
                for (int j = 0; j < maxSize - 1; j++)
                {
                    line += "┴───";
                }
                line += "┘";
            }
            else
            {
                line = "├───";
                for (int j = 0; j < maxSize - 1; j++)
                {
                    line += "┼───";
                }
                line += "┤";
            }

            Console.Write(line);
            Console.WriteLine();
        }

        private static void DisplayGame(Game game)
        {
            Console.WriteLine();
            Console.Write("   ");
            // Affichage des lettres de Colonnes
            for (int col = 0; col < Game.Size; col++)
            {
                Console.Write($"  {Turn.GetColumnName(col)} ");
            }

            Console.WriteLine();

            for (int row = 0; row < Game.Size; row++)
            {

                Console.Write($"   ");
                DrawLine(row, Game.Size);

                Console.Write($" {Turn.GetRowName(row)} ");

                for (int col = 0; col < Game.Size; col++)
                {
                    var letter = "";

                    switch (game.GetTile(col, row))
                    {
                        case Game.Empty: letter = " "; break;
                        case Game.LetterS: letter = "S"; break;
                        case Game.LetterO: letter = "O"; break;
                    }

                    Console.Write("│");
                    Console.Write($" {letter} ");

                }
                Console.WriteLine("│");

            }
            Console.Write($"   ");
            DrawLine(Game.Size, Game.Size);
        }

        static void Main(string[] args)
        {
            Console.Write($"Créer le plus de SOS.\n");

            Game game = new Game();
            var player = "";

            while(game.NumRound < game.NbGameRounds)
            {
                while (game.CurPlayer != null)
                {
                    DisplayGame(game);
                    Turn position = new Turn();
                    try
                    {
                        player = game.CurPlayer == 1 ? "X" : "O";

                        Console.Write($"\nJoueur {player}, Veuillez choisir une case et une lettre (S,O) : ");
                        position = Turn.Parse(Console.ReadLine());
                        var score = game.Play(position);

                        Console.WriteLine($"Joueur {player} Choisit Colonne : {Turn.GetColumnName(position.Column)} | Ligne : {Turn.GetRowName(position.Row)}\n | Lettre :  {position.Letter}");
                        Console.WriteLine($"Score : {score}");
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine($"Case non valide : {e.Message}");

                    }
                    catch (SystemException e)
                    {
                        Console.WriteLine($"Impossible de jouer ici : {e.Message}");
                    }
                }
                Console.WriteLine();
                DisplayGame(game);
                var winner = game.Winner.Value;

                if( winner == 0)
                {
                    Console.WriteLine($"Aucun joueur n'a aligné assez de jetons, C'est reparti pour un tour!");
                }
                else
                {
                    Console.WriteLine($"\nBravo joueur {winner}, tu as gagné la manche {game.NumRound}!");
                }
                //game.resetGame(winner);
            
            }
            DisplayGame(game);
            var finalWinner = game.WinnersByRound.Sum();
            Console.WriteLine($"\nBravo joueur {finalWinner}, tu as gagné!!!");
        }
    }
}
