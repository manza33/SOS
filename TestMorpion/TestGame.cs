using Sos;
using NUnit.Framework;
using System;

namespace TestSos
{
    public class Tests
    {

        private readonly Tile ___ = Tile.Parse(new int[] { 0, 0 }, 0);

        private readonly Tile _S_ = Tile.Parse(new int[] { 0, 0 }, 1); //(0, 1, 0);
        private readonly Tile xS_ = Tile.Parse(new int[] { 1, 0 }, 1); //(1, 1, 0);
        private readonly Tile _Sx = Tile.Parse(new int[] { 0, 1 }, 1); //(0, 1, 1);
        private readonly Tile xSx = Tile.Parse(new int[] { 1, 1 }, 1); //(1, 1, 1);

        private readonly Tile _O_ = Tile.Parse(new int[] { 0, 0 }, -1); //(0, -1, 0);
        private readonly Tile xO_ = Tile.Parse(new int[] { 1, 0 }, -1); //(1, -1, 0);
        private readonly Tile _Ox = Tile.Parse(new int[] { 0, 1 }, -1); //(0, -1, 1);
        private readonly Tile xOx = Tile.Parse(new int[] { 1, 1 }, -1); //(1, -1, 1);

        [Test]
        public void InitialisationBasic()
        {
            var test = new Game();

            var pos = Turn.Parse("A1O");

            Assert.AreEqual(Game.PlayerOne, test.CurPlayer);
            Assert.IsFalse(test.Winner.HasValue);

            Assert.AreEqual(0, test.GetTile(pos).Letter);
            Assert.AreEqual(0, test.GetTile(pos).SosPlayers[0]);
            Assert.AreEqual(0, test.GetTile(pos).SosPlayers[1]);

            CollectionAssert.AreEqual(
                new Tile[] {
                //   A    B    C    D    E  
                    ___, ___, ___, ___, ___, // 1
                    ___, ___, ___, ___, ___, // 2
                    ___, ___, ___, ___, ___, // 3
                    ___, ___, ___, ___, ___, // 4
                    ___, ___, ___, ___, ___, // 5
                },test.Tiles
            );
        }

        [Test]
        public void InitGameWithSpecificBoard()
        {
            var state = new Tile[] {

                 //  A    B    C    D    E  
                    ___, ___, ___, ___, ___, // 1
                    ___, _S_, ___, ___, ___, // 2
                    ___, ___, ___, ___, ___, // 3
                    ___, _Sx, _Ox, _Sx, ___, // 4
                    ___, ___, ___, ___, ___, // 5

                };

            var test = new Game(state, Game.PlayerOne);

            Assert.AreEqual(Game.PlayerOne, test.CurPlayer.Value);
            Assert.IsFalse(test.Winner.HasValue);
            CollectionAssert.AreEqual(state, test.Tiles);
        }

        [Test]
        public void PlayAValidePosition()
        {
            var test = new Game(new Tile[] {
                 //  A    B    C    D    E  
                    ___, ___, ___, ___, ___, // 1
                    ___, _S_, ___, ___, ___, // 2
                    ___, ___, _S_, ___, ___, // 3
                    ___, _Sx, _Ox, _Sx, ___, // 4
                    ___, ___, ___, ___, ___, // 5
                }, Game.PlayerOne);

            var pos = Turn.Parse("C2O");
            test.Play(pos);
            //Assert.AreEqual(1, test.Play(pos));
            Assert.AreEqual(-1, test.GetTile(pos).Letter);
            Assert.AreEqual(1, test.GetTile(pos).SosPlayers[0]);
            Assert.AreEqual(0, test.GetTile(pos).SosPlayers[1]);
            CollectionAssert.AreEqual(
                new Tile[] {
                 //  A    B    C    D    E  
                    ___, ___, ___, ___, ___, // 1
                    ___, _S_, _O_, ___, ___, // 2
                    ___, ___, _S_, ___, ___, // 3
                    ___, _Sx, _Ox, _Sx, ___, // 4
                    ___, ___, ___, ___, ___, // 5
                },
                test.Tiles
            );
        }

        [Test]
        public void PlayAValidePositionWithOAndWriteSOS()
        {
            var test = new Game(new Tile[] {
                 //  A    B    C    D    E  
                    ___, ___, ___, ___, ___, // 1
                    ___, _S_, ___, _S_, ___, // 2
                    ___, ___, ___, ___, ___, // 3
                    ___, _Sx, _Ox, _Sx, ___, // 4
                    ___, ___, ___, ___, ___, // 5
                }, Game.PlayerOne);
            var pos = Turn.Parse("C2O");
            Assert.AreEqual(1, test.Play(pos));
            Assert.AreEqual(-1, test.GetTile(pos).Letter);
            Assert.AreEqual(1, test.GetTile(pos).SosPlayers[0]);
            Assert.AreEqual(0, test.GetTile(pos).SosPlayers[1]);
            Assert.AreEqual(-Game.PlayerOne, test.CurPlayer); // Next Player

            CollectionAssert.AreEqual(
                new Tile[] {
                 //  A    B    C    D    E  
                    ___, ___, ___, ___, ___, // 1
                    ___, xS_, xO_, xS_, ___, // 2
                    ___, ___, ___, ___, ___, // 3
                    ___, _Sx, _Ox, _Sx, ___, // 4
                    ___, ___, ___, ___, ___, // 5
                },
                test.Tiles
            );
        }

        [Test]
        public void PlayMultipleValidPositionsWithOAndWriteSOS()
        {
            var test = new Game(new Tile[] {
                 //  A    B    C    D    E  
                    ___, ___, ___, ___, ___, // 1
                    ___, _S_, ___, ___, ___, // 2
                    _S_, ___, _S_, ___, ___, // 3
                    ___, xS_, _Ox, _Sx, ___, // 4
                    ___, ___, ___, ___, ___, // 5
                }, Game.PlayerTwo);

            Assert.AreEqual(-2, test.Play(Turn.Parse("B3O")));

            CollectionAssert.AreEqual(
                new Tile[] {
                 //  A    B    C    D    E  
                    ___, ___, ___, ___, ___, // 1
                    ___, _Sx, ___, ___, ___, // 2
                    _Sx, _Ox, _Sx, ___, ___, // 3
                    ___, xSx, _Ox, _Sx, ___, // 4
                    ___, ___, ___, ___, ___, // 5
                },
                test.Tiles
            );
        }

        [Test]
        public void PlayMultipleValidPositionsWithSAndWriteSOS()
        {
            var test = new Game(new Tile[] {
                 //  A    B    C    D    E  
                    ___, ___, ___, ___, ___, // 1
                    ___, ___, _O_, _S_, ___, // 2
                    ___, _O_, ___, ___, ___, // 3
                    ___, _Sx, _Ox, _Sx, ___, // 4
                    ___, ___, ___, ___, ___, // 5
                }, Game.PlayerOne);

            Assert.AreEqual(2, test.Play(Turn.Parse("B2S")));

            CollectionAssert.AreEqual(
                new Tile[] {
                 //  A    B    C    D    E  
                    ___, ___, ___, ___, ___, // 1
                    ___, xS_, xO_, xS_, ___, // 2
                    ___, xO_, ___, ___, ___, // 3
                    ___, xSx, _Ox, _Sx, ___, // 4
                    ___, ___, ___, ___, ___, // 5
                },
                test.Tiles
            );
        }

        [Test]
        public void PlayAPositionWhereAlreadyPlayed()
        {
            var test = new Game(new Tile[] {
                 //  A    B    C    D    E  
                    ___, ___, ___, ___, ___, // 1
                    ___, _S_, ___, ___, ___, // 2
                    ___, ___, ___, ___, ___, // 3
                    ___, _Sx, _Ox, _Sx, ___, // 4
                    ___, ___, ___, ___, ___, // 5
                }, Game.PlayerOne);

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
            Assert.Throws<ArgumentException>(() => test.Play(Turn.Parse("B2SO")));        }



    }
}