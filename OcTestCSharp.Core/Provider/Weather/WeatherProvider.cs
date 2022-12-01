using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcTestCSharp.Core.Provider.Weather
{
    public class WeatherProvider : IWeather
    {
        private Random random;

        public WeatherProvider()
        {
            random = new Random();
        }

        public Weather WhatWeather()
        {
            int draw = random.Next(1, 21);
            if (draw < 10)
            {
                return Weather.Sun;
            }
            else if (draw < 20)
            {
                return Weather.Rain;
            }
            return Weather.Storm;
        }
    }
}