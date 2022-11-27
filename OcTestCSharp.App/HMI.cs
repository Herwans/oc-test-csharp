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

            Console.WriteLine($"A l'attaque : points/vie {game.Hero.Points} / {game.Hero.HealthPoints}");

            while (game.Hero.HealthPoints> 0)
            {
                Result result = game.Round(dice.Roll(), dice.Roll());

                switch (result)
                {
                    case Result.Win:
                        Console.Write($"Monster battu");
                        break;
                    case Result.Loose:
                        Console.Write($"Combat perdu");
                        break;
                }

                Console.WriteLine($": points/vie {game.Hero.Points}/{game.Hero.HealthPoints}");
            }
        }
    }
}
