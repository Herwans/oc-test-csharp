using OcTestCSharp.Core.Engine;
using OcTestCSharp.Core.Service;

namespace OcTestCSharp.App.Engine
{
    public class HMI
    {
        public void Start()
        {
            Dice dice = new();
            Game game = new();

            Console.WriteLine($"***************************");
            Console.WriteLine($"Let's fight !");
            Console.WriteLine($"Heath points : {game.Hero.HealthPoints}"); 
            Console.WriteLine($"**********");

            while (game.Hero.HealthPoints> 0)
            {
                Result result = game.Round(dice.Roll(), dice.Roll());

                switch (result)
                {
                    case Result.Win:
                        Console.Write($"Monster beats !");
                        break;
                    case Result.Loose:
                        Console.Write($"You loose...");
                        break;
                }

                Console.WriteLine($"\t Health remaining : {game.Hero.HealthPoints} \t/ Wins : {game.Hero.Points}");
            }

            Console.WriteLine($"The hero has fallen after {game.Hero.Points} wins... Be the gods protect us.");

        }
    }
}
