using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Weather.ObserverPattern.DisplayElements
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float max = 0;
        private float min = 100;
        private float sum = 0;
        private int i = 0;

        private ISubject weatherData;


        public StatisticsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            this.weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("平均/最高/最低:" + (sum/i) + "/" + max + "/" + min+" 度。");
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            i++;
            sum = sum + temperature;
            if (temperature > max)
            {
                max = temperature;
            }
            if (temperature < min)
            {
                min = temperature;
            }
            Display();
        }
    }
}
