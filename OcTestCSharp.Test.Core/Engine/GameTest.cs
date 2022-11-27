using FluentAssertions;
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

            result.Should().Be(Result.Win);
            game.Hero.Points.Should().Be(1);
            game.Hero.HealthPoints.Should().Be(15);
        }

        [TestMethod]
        public void Round_Even()
        {
            Game game = new();

            Result result = game.Round(5, 5);

            result.Should().Be(Result.Win);
            game.Hero.Points.Should().Be(1);
            game.Hero.HealthPoints.Should().Be(15);
        }

        [TestMethod]
        public void Round_Loose()
        {
            Game game = new();

            Result result = game.Round(2, 4);

            result.Should().Be(Result.Loose);
            game.Hero.Points.Should().Be(0);
            game.Hero.HealthPoints.Should().Be(13);
        }
    }
}