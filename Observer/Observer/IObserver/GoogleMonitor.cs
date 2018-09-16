using System;

namespace Observer.IObserver
{
    public class GoogleMonitor : IObserver<Stock>
    {
        public void OnCompleted()
        {
            Console.WriteLine("End of trading day");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("Error occured in the stock ticker");
        }

        public void OnNext(Stock stock)
        {
            if (stock.Symbol == "GOOG")
                Console.WriteLine("Google's new price is: {0}", stock.Price);
        }
    }
}
