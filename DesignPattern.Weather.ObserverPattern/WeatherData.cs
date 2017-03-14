using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Weather.ObserverPattern
{
    public class WeatherData : ISubject
    {
        private IList<IObserver> observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        /// <summary>
        /// 主题对象改变通知所有订阅观察者
        /// </summary>
        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        /// <summary>
        /// 主题对象的改变
        /// </summary>
        /// <param name="temperature"></param>
        /// <param name="humidity"></param>
        /// <param name="pressure"></param>
        public void SetMeasurements(float temperature,float humidity,float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }
    
        /// <summary>
        /// 通知订阅者
        /// </summary>
        public void NotifyObservers()
        {
            foreach (var item in observers)
            {
                IObserver observer = (IObserver)item;
                observer.Update(temperature, humidity, pressure);
            }
        }

        /// <summary>
        /// 观察者订阅
        /// </summary>
        /// <param name="o"></param>
        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        /// <summary>
        /// 观察者取消订阅
        /// </summary>
        /// <param name="o"></param>
        public void RemoveObserver(IObserver o)
        {
            if (observers.IndexOf(o) >= 0)
            {
                observers.Remove(o);
            }
        }
    }
}
