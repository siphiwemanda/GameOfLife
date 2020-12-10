using GameOfLife;
using NUnit.Framework;

namespace GameOfLifeTests
{
    [TestFixture]
    public class GameTests
    {
        [Test]
        public void LivingCellWithZeroNeighborsDies()
        {
           
           var board = new [,] {{false, false, false}, {false, true, false}, {false, false, false}};
           var game = new Game(board);
           game.Evolve();
           Assert.That(game.IsAlive(1,1), Is.False);

        }
        [Test]
        public void LivingCellWithOneNeighborsDies()
        {

            var board = new[,] { { false, true, false }, 
                                 { false, true, false }, 
                                 { false, false, false } };
            var game = new Game(board);
            game.Evolve();
            Assert.That(game.IsAlive(1, 1), Is.False);

        }
        [Test]
        public void LivingCellWithTwoNeighborsLives()
        {

            var board = new[,] { { false, true, false },
                                { false, true, true },
                                { false, false, false } };
            var game = new Game(board);
            game.Evolve();
            Assert.That(game.IsAlive(1, 1), Is.True);

        }
    }
}
