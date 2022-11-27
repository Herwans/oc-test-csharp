using OcTestCSharp.Core.Engine;

namespace OcTestCSharp.Test.Core.Engine
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void Round_Win()
        {
            // Arrange
            Game game = new();

            // Act
            Result result = game.Round(6, 1);

            if (result != Result.Win) Assert.Fail();
            if (game.Hero.Points != 1) Assert.Fail();
            if (game.Hero.HealthPoints != 15) Assert.Fail();
        }

        [TestMethod]
        public void Round_Even()
        {
            Game game = new();

            Result result = game.Round(5, 5);

            if (result != Result.Win) Assert.Fail();
            if (game.Hero.Points != 1) Assert.Fail();
            if (game.Hero.HealthPoints != 15) Assert.Fail();
        }

        [TestMethod]
        public void Round_Loose()
        {
            Game game = new();

            Result result = game.Round(2, 4);

            if (result != Result.Loose) Assert.Fail();
            if (game.Hero.Points != 0) Assert.Fail();
            if (game.Hero.HealthPoints != 13) Assert.Fail();
        }
    }
}