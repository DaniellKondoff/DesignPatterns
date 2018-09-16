using System;

namespace Observer.TraditionalObs
{
    public class GoogleObserver : AbstractObserver
    {
        private StockTicker DataSource { get; set; }

        public GoogleObserver(StockTicker subject)
        {
            this.DataSource = subject;
            subject.Register(this);
        }
        public override void Update()
        {
            decimal price = DataSource.Stock.Price;
            string symbol = DataSource.Stock.Symbol;

            if (symbol == "GOOG")
            {
                Console.WriteLine($"Google's new price is: {price}");
            }
        }
    }
}
