﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sos
{
    public struct Tile
    {

        //private static int[] _sosPlayers = new int[] { 0, 0 };

        public Tile(int[] sosPlayers, int letter)
        {
            SosPlayers = sosPlayers;
            Letter = letter;
        }

        public static Tile Parse()
        {
            return new Tile(new int[] { 0, 0 }, 0);
        }

        public static Tile Parse(int[] sosPlayers, int letter)
        {
            return new Tile(sosPlayers, letter);
        }

        public void AddSosPlayer(int player)
        {
            CheckLetterPlayer(player);
            if(player == Game.PlayerOne)
            {
                SosPlayers[0] = player;
            }
            else
            {
                SosPlayers[1] = player;
            }
        }

        public void AddLetter(int letter)
        {
            CheckLetterPlayer(letter);
            Letter = letter;
        }

        public int[] SosPlayers { get; private set; }
        public int Letter { get; private set; }

        private static void CheckLetterPlayer(int letterPlayer)
        {
            if (letterPlayer != 1 && letterPlayer != -1)
            {
                throw new ArgumentException($"Bad Player/Letter ({letterPlayer})");
            }
        }
    }
}