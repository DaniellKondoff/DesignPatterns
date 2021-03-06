﻿using System;

namespace Observer.IObserver
{
    public class MicrosoftMonitor : IObserver<Stock>
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
            if (stock.Symbol == "MSFT" && stock.Price > 10.00m)
                Console.WriteLine("Microsoft has reached the target price: {0}", stock.Price);
        }
    }
}
