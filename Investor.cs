using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Practice
{
    internal class Investor: IObserver
    {
        private string name;
        public Investor(string name)
        {
            this.name = name;
        }

        public void Update(string stockSymbol, double price)
        {
            Console.WriteLine($"{name} received update: {stockSymbol} is now {price}");
        }


    }
}
