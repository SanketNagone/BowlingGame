using BowlingGame;

namespace BowlingGameTest
{
    public class Tests
    {
        Game game;

        [SetUp]
        public void Setup()
        {
            game = new Game();
        }

        [Test]
        public void CanThrowAllGutters()
        {
            ThrowMultiple(0,20);

            Assert.AreEqual(0, game.Score);
        }

        [Test]
        public void CanThrowAllOnes()
        {
            ThrowMultiple(1, 20);

            Assert.AreEqual(20, game.Score);
        }

        [Test]
        public void CanThrowSpares()
        {
            game.Throw(5);
            game.Throw(5);
            game.Throw(3);
            ThrowMultiple(0, 17);

            Assert.AreEqual(16, game.Score);
        }

        [Test]
        public void CanThrowStrikes()
        {
            game.Throw(10);
            game.Throw(4);
            game.Throw(3);
            ThrowMultiple(0, 16);

            Assert.AreEqual(24, game.Score);
        }


        [Test]
        public void CanThrowPerfectGame()
        {
            ThrowMultiple(10, 12);

            Assert.AreEqual(300, game.Score);
        }

        [Test]
        public void SampleGameScore()
        {
            game.Throw(10);
            
            game.Throw(9);
            game.Throw(1);

            game.Throw(5);
            game.Throw(5);

            game.Throw(7);
            game.Throw(2);

            game.Throw(10);
            game.Throw(10);
            game.Throw(10);


            game.Throw(9);
            game.Throw(0);

            game.Throw(8);
            game.Throw(2);


            game.Throw(9);
            game.Throw(1);
            game.Throw(10);
   

            Assert.AreEqual(187, game.Score);
        }

        private void ThrowMultiple(int pins, int rolls)
        {
            for (int i = 0; i < rolls; i++)
            {
                game.Throw(pins);
            }
        }

    }
}