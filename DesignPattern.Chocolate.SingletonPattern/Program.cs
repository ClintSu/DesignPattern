using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Chocolate.SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ChocolateBoiler boilder = ChocolateBoiler.GetInstance();
            boilder.Fill();
            boilder.Boil();
            boilder.Drain();
        }
    }
}
