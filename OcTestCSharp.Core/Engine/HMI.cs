using OcTestCSharp.Core.Engine;
using OcTestCSharp.Core.Provider.Weather;
using OcTestCSharp.Core.Service.Dice;
using OcTestCSharp.Core.Service.InputOutput;

namespace OcTestCSharp.Core.Engine
{
    public class HMI
    {
        private readonly IOutput output;

        private readonly IDice dice;
        private readonly IWeather weather;

        public HMI(IOutput output, IDice dice, IWeather weather)
        {
            this.output = output;
            this.dice = dice;
            this.weather = weather;
        }

        public void Start()
        {
            Game game = new(weather);

            output.WriteLine($"Let's fight !");

            while (game.Hero.HealthPoints > 0)
            {
                Result result = game.Round(dice.Roll(), dice.Roll());

                switch (result)
                {
                    case Result.Win:
                        output.Write($"Monster beats !");
                        break;

                    case Result.Loose:
                        output.Write($"You loose...");
                        break;
                }

                output.WriteLine($"\t Health remaining : {game.Hero.HealthPoints} \t/ Wins : {game.Hero.Points}");
            }

            output.WriteLine($"The hero has fallen after {game.Hero.Points} wins... Be the gods protect us.");
        }
    }
}