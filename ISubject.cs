using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Practice
{
    internal interface ISubject
    {
        void Attach(IObserver observer);
        void Detatch(IObserver observer);

        void Notify(string stockSymbol, double price);
    }
}
