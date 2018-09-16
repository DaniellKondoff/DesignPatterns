using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.TraditionalObs
{
    public class MicrosoftObserver : AbstractObserver
    {
        private StockTicker DataSource { get; set; }

        public MicrosoftObserver(StockTicker subject)
        {
            this.DataSource = subject;
            subject.Register(this);
        }
        public override void Update()
        {
            decimal price = DataSource.Stock.Price;
            string symbol = DataSource.Stock.Symbol;

            if (symbol == "MSFT" && price > 10.00m)
            {
                Console.WriteLine($"Microsoft has reached the target price: {price}");
            }
        }
    }
}
