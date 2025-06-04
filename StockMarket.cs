using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Practice
{
    internal class StockMarket : ISubject
    {
        List<IObserver> observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detatch(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify(string stockSymbol, double price)
        {
            foreach(var observer in observers)
            {
                observer.Update(stockSymbol, price);
            }
        }

        public void UpdateStockPrice(string stockSymbol, double price)
        {
            Console.WriteLine($"\nStockmarket: {stockSymbol} Price changed to {price}");
            Notify(stockSymbol, price);
        }
    }
}
