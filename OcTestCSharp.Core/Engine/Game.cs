using OcTestCSharp.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcTestCSharp.Core.Engine
{
    public enum Result
    {
        Win,
        Loose
    }

    public class Game
    {
        public Hero Hero { get; set; }

        public Game()
        {
            Hero = new(15);
        }

        public Result Round(int heroDice, int monsterDice)
        {
            if (WinFight(heroDice, monsterDice))
            {
                Hero.WinFight();
                return Result.Win;
            }

            Hero.LooseFight(monsterDice - heroDice);
            return Result.Loose;
        }

        private bool WinFight(int dice1, int dice2)
        {
            return dice1 >= dice2;
        }
    }
}
