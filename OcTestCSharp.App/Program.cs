// See https://aka.ms/new-console-template for more information
using OcTestCSharp.Core.Engine;
using OcTestCSharp.Core.Provider.Weather;
using OcTestCSharp.Core.Service.Dice;
using OcTestCSharp.Core.Service.InputOutput;

HMI hmi = new(new ConsoleOutput(), new Dice(), new WeatherProvider());

hmi.Start();