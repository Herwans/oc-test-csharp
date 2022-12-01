using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcTestCSharp.Core.Provider.Weather
{
    public enum Weather
    {
        Sun,
        Rain,
        Storm
    }

    public interface IWeather
    {
        public Weather WhatWeather();
    }
}