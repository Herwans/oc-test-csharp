using OcTestCSharp.Core.Model;
using OcTestCSharp.Core.Provider.Weather;
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
        private readonly IWeather weatherProvider;

        public Hero Hero { get; set; }

        public Game(IWeather weatherProvider)
        {
            Hero = new(15);
            this.weatherProvider = weatherProvider;
        }

        public Result Round(int heroDice, int monsterDice)
        {
            if (WinFight(heroDice, monsterDice))
            {
                Hero.WinFight();
                return Result.Win;
            }

            Weather weather = weatherProvider.WhatWeather();

            int damage = monsterDice - heroDice;

            if (weather == Weather.Storm)
            {
                damage *= 2;
            }

            Hero.LooseFight(damage);
            return Result.Loose;
        }

        private bool WinFight(int dice1, int dice2)
        {
            return dice1 >= dice2;
        }
    }
}