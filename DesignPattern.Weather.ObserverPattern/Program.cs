using DesignPattern.Weather.ObserverPattern.DisplayElements;
using System;

namespace DesignPattern.Weather.ObserverPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData(); //建立WeatherData对象

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData); //建立订阅者
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);   //建立订阅者


            weatherData.SetMeasurements(80, 65, 30.4f);   //模拟天气变化
            weatherData.SetMeasurements(82, 75, 29.2f);
            weatherData.SetMeasurements(90, 80, 29.2f);

            Console.ReadLine();
        }
    }
}