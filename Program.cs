using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StockMarket market = new StockMarket();

            Investor alice = new Investor("Alice");
            Investor bob = new Investor("Bob");

            market.Attach(alice);
            market.Attach(bob);

            market.UpdateStockPrice("AAPL", 150.25);
            market.UpdateStockPrice("GOOGL", 2750.10);

            market.Detatch(bob);
            market.UpdateStockPrice("MSFT", 300.00);
        }
    }
}
