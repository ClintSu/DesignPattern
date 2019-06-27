using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Weather.ObserverPattern
{
    public interface ISubject
    {
        void RegisterObserver(IObserver o);  //订阅
        void RemoveObserver(IObserver o);  //取消
        void NotifyObservers();  //通知
        
    }
}
