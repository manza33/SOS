using Sos;
using NUnit.Framework;
using System;

namespace TestSos
{
    public class Tests
    {
        private const int _ = 0, O = -1, S = 1;

        [Test]
        public void InitialisationBasic()
        {
            var test = new Game();

            Assert.AreEqual(Game.PlayerOne, test.CurPlayer);
            Assert.IsFalse(test.Winner.HasValue);
            CollectionAssert.AreEqual(
                new (int isPlayerOneSos, int nbTokenMax, int isPlayerTwoSos)[] {
                //     A        B        C        D        E  
                    (0,_,0), (0,_,0), (0,_,0), (0,_,0), (0,_,0), // 1
                    (0,_,0), (0,_,0), (0,_,0), (0,_,0), (0,_,0), // 2
                    (0,_,0), (0,_,0), (0,_,0), (0,_,0), (0,_,0), // 3
                    (0,_,0), (0,_,0), (0,_,0), (0,_,0), (0,_,0), // 4
                    (0,_,0), (0,_,0), (0,_,0), (0,_,0), (0,_,0), // 5
                },
                test.Tiles
            );
        }
        [Test]
        public void InitGameWithSpecificBoard()
        {
            var state = new (int isPlayerOneSos, int nbTokenMax, int isPlayerTwoSos)[] {
                //     A        B        C        D        E  
                    (0,_,0), (0,_,0), (0,_,0), (0,_,0), (0,_,0), // 1
                    (0,_,0), (0,S,0), (0,_,0), (0,_,0), (0,_,0), // 2
                    (0,_,0), (0,_,0), (0,_,0), (0,_,0), (0,_,0), // 3
                    (0,_,0), (0,S,1), (0,O,1), (0,S,1), (0,_,0), // 4
                    (0,_,0), (0,_,0), (0,_,0), (0,_,0), (0,_,0), // 5
                },
            var test = new Game(state, Game.PlayerOne);

            Assert.AreEqual(Game.PlayerOne, test.CurPlayer.Value);
            Assert.IsFalse(test.Winner.HasValue);
            CollectionAssert.AreEqual(state, test.Tiles);
        }


        [Test]
        public void PlayAPositionWhereAlreadyPlayed()
        {
            var test = new Game(new int[] {
            //  A  B  C  D  E  F  G  H
                _, _, _, _, _, _, _, _, // 1
                _, S, _, _, _, _, _, _, // 2
                _, _, _, _, _, _, _, _, // 3
                _, _, _, _, _, O, _, _, // 4
                _, _, _, _, _, _, _, _, // 5
                _, _, _, _, _, _, _, _, // 6
                _, _, _, _, _, _, _, _, // 7
                _, _, _, _, _, _, _, _  // 8
            }, Game.PlayerOne, idGameSize: 2);

            Assert.Throws<InvalidOperationException>(() => test.Play(Turn.Parse("B2S")));
        }

        [Test] 
        public void PlayPositionOutOfRange()
        {
            var test = new Game();
            Assert.Throws<ArgumentOutOfRangeException>(() => test.Play(Turn.Parse("K2O")));
        }

        [Test]
        public void PlayBadLetter()
        {
            var test = new Game();
            Assert.Throws<ArgumentException>(() => test.Play(Turn.Parse("B2T")));
        }

        [Test]
        public void PlayWithBadInput()
        {
            var test = new Game();
            Assert.Throws<ArgumentException>(() => test.Play(Turn.Parse("B2SO")));
        }



    }
}