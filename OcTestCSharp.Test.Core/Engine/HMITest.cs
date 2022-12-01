using FluentAssertions;
using OcTestCSharp.Core.Engine;
using OcTestCSharp.Test.Core.Stubs;

namespace OcTestCSharp.Test.Core.Engine
{
    [TestClass]
    public class HMITest
    {
        [TestMethod]
        public void Start_PlayerWin()
        {
            ConsoleOutput console = new();
            HMI hmi = new(console, new Dice());

            hmi.Start();

            var result = console.StringBuilder.ToString();
            result.Should().StartWith("Let's fight !\r\n");
            result.Should().EndWith("The hero has fallen after 9 wins... Be the gods protect us.\r\n");
        }
    }
}